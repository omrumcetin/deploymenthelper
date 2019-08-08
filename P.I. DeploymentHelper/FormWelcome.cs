using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO.Compression;
using System.Threading;
using System.Security.Principal;

namespace P.I.DeploymentHelper
{
    public partial class Form_Welcome : Form
    {
        #region ClassVariables
        private bool windowMovable = false;
        private int mouseValueX;
        private int mouseValueY;
        private IEnumerable<string> files;
        private IEnumerable<string> storedPipelineSelections { get; set; }
        private IEnumerable<string> storedPortableSelections { get; set; }
        private List<string> portables = new List<string>();
        private readonly string pipelinePath = @"Pipelines\";
        
        #endregion
        public Form_Welcome()
        {
            InitializeComponent();
  
        }
        #region Template
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Form_welcome_MouseUp(object sender, MouseEventArgs e)
        {
            windowMovable = false;

        }

        private void Form_welcome_MouseDown(object sender, MouseEventArgs e)
        {
            windowMovable = true;
            mouseValueX = e.X;
            mouseValueY = e.Y;
        }

        private void Form_welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (windowMovable)
            {
                this.SetDesktopLocation(MousePosition.X - mouseValueX, MousePosition.Y - mouseValueY);
            }
        }
        #endregion
        private void Form_Welcome_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Pipelines");
            Directory.CreateDirectory("PortableSoftwares");
            storedPipelineSelections = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();
            storedPortableSelections = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
        }
        private void Form_Welcome_Activated(object sender, EventArgs e)
        {
            //Sources window
            ListBox_Pipelines.Items.Clear();
            files = Directory.EnumerateFiles(pipelinePath, "*.xml", SearchOption.AllDirectories);
            foreach (string file in files)
            { 
                string fileName = file.Substring(pipelinePath.Length);
                if (storedPipelineSelections.Contains(fileName))
                {
                    var index = ListBox_Pipelines.Items.Add(fileName);
                    ListBox_Pipelines.SetSelected(index, true);
                }
                else
                {
                    ListBox_Pipelines.Items.Add(fileName);
                }
                
            }
            //Portable window
            ListBox_Portables.Items.Clear();
            ToolsConfigSection customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            foreach (PortableConfigElement portableElement in customConfig.portables)
            {
                if (storedPortableSelections.Contains(portableElement.name))
                {
                    var index = ListBox_Portables.Items.Add(portableElement.name);
                    ListBox_Portables.SetSelected(index, true);
                }
                else
                {
                    ListBox_Portables.Items.Add(portableElement.name);
                    if (!portables.Contains(portableElement.name))
                    {
                        portables.Add(portableElement.name);
                    }                    
                }                
            }

        }
        private void TextBox_Pipelines_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<string> storedSelections = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();
            ListBox_Pipelines.Items.Clear();
            Regex rx = new Regex($"(?i).*{FilterBox_Pipelines.Text}.*(?-i)");
            foreach (string storedItem in storedSelections)
            {
                var selectedIndex = ListBox_Pipelines.Items.Add(storedItem);
                ListBox_Pipelines.SetSelected(selectedIndex, true);
            }
            foreach (string file in files)
            {
                string fileName = file.Substring(pipelinePath.Length);
                if (rx.IsMatch(fileName) && !storedSelections.Contains<string>(fileName))
                {
                    ListBox_Pipelines.Items.Add(fileName);
                }
                    
            }                        
        }
        private void TextBox_Portables_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<string> storedSelections = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
            ListBox_Portables.Items.Clear();
            Regex rx = new Regex($"(?i).*{FilterBox_Portables.Text}.*(?-i)");
            foreach (string storedItem in storedSelections)
            {
                var selectedIndex = ListBox_Portables.Items.Add(storedItem);
                ListBox_Portables.SetSelected(selectedIndex, true);
            }
            foreach (string portable in portables)
            {
                if (rx.IsMatch(portable) && !storedSelections.Contains<string>(portable))
                {
                    ListBox_Portables.Items.Add(portable);
                }

            }
        }
        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BttnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //TODO create bat file

            //create zip file
            ToolsConfigSection customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            IEnumerable<PortableConfigElement> configs = customConfig.portables.Cast<PortableConfigElement>();
            IEnumerable<string> cachePortableCache = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
            IEnumerable<string> cachePipelines = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip Archive|*.zip";
            saveFileDialog.Title = "Save your Deployment Zip File";
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            if (cachePortableCache.FirstOrDefault() != null || cachePipelines.FirstOrDefault() != null)
            {
                CreateBatchFile(configs);
                loadingButton.BringToFront();
                ButtonSubmit.Enabled = false;
                Thread t1 = new Thread(
                    delegate()
                    {   
                        
                        if (saveFileDialog.OverwritePrompt)
                        {
                            File.Delete(saveFileDialog.FileName);
                        }
                        using (ZipArchive newFile = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create))
                        {
                            foreach (string name in cachePortableCache)
                            {
                                var singleConfig = configs.Where(x => x.name == name).FirstOrDefault();
                                if (singleConfig != null)
                                {
                                    try
                                    {
                                        newFile.CreateEntryFromFile(string.Concat(@"PortableSoftwares\", singleConfig.filename), singleConfig.filename);
                                    }
                                    catch
                                    {
                                        MessageBox.Show($"Couldnt find file in Portables folder : {singleConfig.filename}","File Not Found!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            foreach (string name in cachePipelines)
                            {
                                newFile.CreateEntryFromFile(string.Concat(@"Pipelines\", name), string.Concat(@"Pipelines\", name));
                            }
                            newFile.CreateEntryFromFile("Deploy.bat", "Deploy.bat");
                        }
                                           

                        Invoke((MethodInvoker)delegate {
                            loadingButton.SendToBack();
                            ButtonSubmit.Enabled = true;
                        });
                    });
                t1.Start();
            }
            else
            {
                MessageBox.Show("You did not select anything to create zip file!","Retry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form_Welcome_Deactivate(object sender, EventArgs e)
        {
            storedPipelineSelections = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();
            storedPortableSelections = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
        }
        private void RemoteSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PortableSoftwares formPortableSoftwares = new Form_PortableSoftwares();
            formPortableSoftwares.ShowDialog();
        }
        private void FetchPipelinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox_Pipelines.Enabled = false;
            FilterBox_Pipelines.Enabled = false;
            LoadingBar.Visible = true;
            LoadingBar.BringToFront();
            Thread fetchPipelines = new Thread(
                delegate () 
                {
                    IEnumerable<string> directories = Directory.GetDirectories(@"\\V10S6-ITFILESRV\Share\Departments\Integration\Other\Deployments\","pipelines",SearchOption.AllDirectories);
                    foreach(var directory in directories)
                    {
                        var directoryName = Path.GetFileName(Directory.GetParent(directory).ToString());
                        var createdDirectoryPath = Directory.CreateDirectory(string.Concat(pipelinePath, directoryName));
                        
                        //access
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        WindowsIdentity idnt = new WindowsIdentity(WindowsIdentity.GetCurrent().Token);
                        WindowsImpersonationContext context = idnt.Impersonate();

                        //copy
                        var fileList = Directory.GetFiles(directory);
                        foreach (var sourceFile in fileList)
                        {
                            string fileName = sourceFile.Substring(directory.ToString().Length);
                            string destFile = string.Concat(createdDirectoryPath.FullName.ToString(), fileName);
                            File.Copy(sourceFile, destFile, true);
                        }
                    }
                    Invoke((MethodInvoker)delegate {
                        ListBox_Pipelines.Enabled = true;
                        FilterBox_Pipelines.Enabled = true;
                        LoadingBar.Visible = false;
                        Form_Welcome_Activated(sender, e);
                    });
                    
                });
            fetchPipelines.Start();
        }
        private void CreateBatchFile(IEnumerable<PortableConfigElement>  configs)
        {
            StreamWriter sw = new StreamWriter("Deploy.bat");
            string zipExecutablePath = string.Empty;
            bool setEnvironmentVariableForOracle = false;
            var selectedPortables = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
            foreach (var selectedPortable in selectedPortables)
            {
                if (selectedPortable == "7Zip")
                {
                    var zipConfig = configs.Where(x => x.name == "7Zip").FirstOrDefault();
                    sw.WriteLine("@echo off\n" +
                        "setlocal\n" +
                        "cd /d %~dp0\n" +
                        $"md \"{zipConfig.remotepath}\"" +
                        $"\nCall :UnZipFile \"{zipConfig.remotepath}\" \"%~dp0{zipConfig.filename}\"" +
                        "\nexit /b" +
                        "\n:UnZipFile <ExtractTo> <newzipfile>" +
                        "\nset vbs=\"%temp%\\_.vbs\"" +
                        "\nif exist %vbs% del /f /q %vbs%" +
                        "\n>%vbs% echo set objShell = CreateObject(\"Shell.Application\")" +
                        "\n>>%vbs% echo set FilesInZip=objShell.NameSpace(%2).items" +
                        "\n>>%vbs% echo objShell.NameSpace(%1).CopyHere(FilesInZip)" +
                        "\n>>%vbs% echo Set fso = Nothing" +
                        "\n>>%vbs% echo Set objShell = Nothing" +
                        "\ncscript //nologo %vbs%" +
                        "\nif exist %vbs% del /f /q %vbs%\n");
                    zipExecutablePath = $"{zipConfig.remotepath}\\7z.exe";
                }
            }
            if (zipExecutablePath == string.Empty)
            {
                zipExecutablePath = @"C:\Program Files\7-Zip\7z.exe";
            }
            foreach (var selectedPortable in selectedPortables)
            {
                if (selectedPortable != "7Zip")
                {
                    var portableConfig = configs.Where(x => x.name == selectedPortable).FirstOrDefault();
                    sw.WriteLine($"md \"{portableConfig.remotepath}\"");
                    sw.WriteLine($"\"{zipExecutablePath}\" x \"{portableConfig.filename}\" -o\"{portableConfig.remotepath}\"");
                }
                if (selectedPortable == "Instant Client Basic") { setEnvironmentVariableForOracle = true; }
            }
            if (setEnvironmentVariableForOracle)
            {
                var portableConfig = configs.Where(x => x.name == "Instant Client Basic").FirstOrDefault();
                sw.WriteLine("\n\n@echo off" +
                    $"\nset /p variable=Do you want to add oracle path({portableConfig.remotepath}) to environment variables(Y\\N): " +
                    "\nif %variable%==Y goto execute" +
                    "\nif %variable%==y goto execute" +
                    "\ngoto end" +
                    "\n:execute" +
                    $"\nsetx path \"%PATH%;{portableConfig.remotepath}\" / M" +
                    "\n:end");
            }
            //adding oracle home environment variable
            sw.Close();
        }

    }
}
