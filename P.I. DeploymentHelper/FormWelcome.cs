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
        private ToolsConfigSection customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
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
            progressBar.Visible = false;
            progressBar.Minimum = 1;
            progressBar.Value = 1;
            progressBar.Step = 1;
            storedPipelineSelections = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();
            storedPortableSelections = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
        }
        private void Form_Welcome_Activated(object sender, EventArgs e)
        {
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
            ListBox_Portables.Items.Clear();
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
                    portables.Add(portableElement.name);
                }                
            }

        }
        private void TextBox_Pipelines_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<string> storedSelections = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();
            ListBox_Pipelines.Items.Clear();
            Regex rx = new Regex($"(?i).*{tb_source.Text}.*(?-i)");
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
            Regex rx = new Regex($"(?i).*{tb_portableSource.Text}.*(?-i)");
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
            IEnumerable<PortableConfigElement> configs = customConfig.portables.Cast<PortableConfigElement>();
            IEnumerable<string> cachePortableCache = ListBox_Portables.SelectedItems.Cast<string>().ToArray();
            IEnumerable<string> cachePipelines = ListBox_Pipelines.SelectedItems.Cast<string>().ToArray();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip Archive|*.zip";
            saveFileDialog.Title = "Save your Deployment Zip File";
            saveFileDialog.ShowDialog();

            if (cachePortableCache.FirstOrDefault() != null || cachePipelines.FirstOrDefault() != null)
            {
                progressBar.Visible = true;
                progressBar.Maximum = cachePortableCache.Count() + cachePipelines.Count() + 2;
                Thread t1 = new Thread(
                    delegate()
                    {   
                        try
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
                                        newFile.CreateEntryFromFile(string.Concat(@"PortableSoftwares\", singleConfig.filename), singleConfig.filename);
                                    }
                                    Invoke((MethodInvoker)delegate { progressBar.PerformStep(); });
                                }
                                foreach (string name in cachePipelines)
                                {
                                    newFile.CreateEntryFromFile(string.Concat(@"Pipelines\", name), string.Concat(@"Pipelines\", name));
                                    Invoke((MethodInvoker)delegate { progressBar.PerformStep(); });
                                }
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString());
                        }                    

                        Invoke((MethodInvoker)delegate {
                            progressBar.PerformStep();
                            progressBar.Visible = false;
                            progressBar.Value = 1;
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

                });
            fetchPipelines.Start();
        }
    }
}
