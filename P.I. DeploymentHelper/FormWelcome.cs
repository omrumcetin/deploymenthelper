using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO.Compression;
using System.Threading;

namespace P.I.DeploymentHelper
{
    public partial class form_welcome : Form
    {
        #region ClassVariables
        private bool windowMovable = false;
        private int mouseValueX;
        private int mouseValueY;
        private IEnumerable<string> files;
        private List<string> portables = new List<string>();
        private readonly string path = @"Pipelines\";
        private bool IsCancelled = false;
        private ToolsConfigSection customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
        #endregion
        public form_welcome()
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
        private void Form_welcome_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Pipelines");
            Directory.CreateDirectory("PortableSoftwares");
            ButtonCancel.Visible = false;
            progressBar.Visible = false;
            progressBar.Minimum = 1;
            progressBar.Value = 1;
            progressBar.Step = 1;
        }
        private void Form_welcome_Activated(object sender, EventArgs e)
        {
            lb_source.Items.Clear();
            files = Directory.EnumerateFiles(path, "*.xml", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string fileName = file.Substring(path.Length);
                lb_source.Items.Add(fileName);
            }
            lb_portableSource.Items.Clear();
            foreach (PortableConfigElement portableElement in customConfig.portables)
            {
                lb_portableSource.Items.Add(portableElement.name);
                portables.Add(portableElement.name);
            }

        }
        private void Tb_source_TextChanged(object sender, EventArgs e)
        {
            var selectedItems = lb_source.SelectedItems;
            List<string> storedSelections = new List<string>();

            foreach (string selectedItem in selectedItems)
            {
                storedSelections.Add(selectedItem);
            }

            lb_source.Items.Clear();

            Regex rx = new Regex($"(?i).*{tb_source.Text}.*(?-i)");

            foreach (string storedItem in storedSelections)
            {
                var selectedIndex = lb_source.Items.Add(storedItem);
                lb_source.SetSelected(selectedIndex, true);
            }

            foreach (string file in files)
            {
                string fileName = file.Substring(path.Length);
                if (rx.IsMatch(fileName) && !storedSelections.Contains<string>(fileName))
                {
                    lb_source.Items.Add(fileName);
                }
                    
            }                        
        }
        private void Tb_portableSource_TextChanged(object sender, EventArgs e)
        {
            var selectedItems = lb_portableSource.SelectedItems;
            List<string> storedSelections = new List<string>();
            foreach (string selectedItem in selectedItems)
            {
                storedSelections.Add(selectedItem);
            }

            lb_portableSource.Items.Clear();

            Regex rx = new Regex($"(?i).*{tb_portableSource.Text}.*(?-i)");

            foreach (string storedItem in storedSelections)
            {
                var selectedIndex = lb_portableSource.Items.Add(storedItem);
                lb_portableSource.SetSelected(selectedIndex, true);
            }

            foreach (string portable in portables)
            {
                if (rx.IsMatch(portable) && !storedSelections.Contains<string>(portable))
                {
                    lb_portableSource.Items.Add(portable);
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
        private void RemoteSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPortableSoftwares formPortableSoftwares = new FormPortableSoftwares();
            formPortableSoftwares.ShowDialog();
        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //TODO create bat file
            IEnumerable<PortableConfigElement> configs = customConfig.portables.Cast<PortableConfigElement>();
            IEnumerable<string> cachePortableCache = lb_portableSource.SelectedItems.Cast<string>();
            IEnumerable<string> cachePipelines = lb_source.SelectedItems.Cast<string>();

            if (cachePortableCache.FirstOrDefault() != null || cachePipelines.FirstOrDefault() != null)
            {
                ButtonCancel.Visible = true;
                progressBar.Visible = true;
                progressBar.Maximum = cachePortableCache.Count() + cachePipelines.Count();
                Thread t1 = new Thread(delegate()
                {   
                    using (ZipArchive newFile = ZipFile.Open("Deployment.zip", ZipArchiveMode.Update))
                    {
                        foreach (string name in cachePortableCache)
                        {
                            var singleConfig = configs.Where(x => x.name == name).FirstOrDefault();
                            if (singleConfig != null)
                            {
                                newFile.CreateEntryFromFile(string.Concat(@"PortableSoftwares\", singleConfig.filename), singleConfig.filename);
                            }
                            Invoke((MethodInvoker)delegate{progressBar.PerformStep();});
                            
                        }
                        foreach (string name in cachePipelines)
                        {
                            newFile.CreateEntryFromFile(string.Concat(@"Pipelines\", name), string.Concat(@"Pipelines\", name));
                            Invoke((MethodInvoker)delegate { progressBar.PerformStep(); });
                        }
                    }
                    //ButtonCancel.Visible = false;
                    Invoke((MethodInvoker)delegate { ButtonCancel.Visible = false; });
                    //progressBar.Visible = false;
                    Invoke((MethodInvoker)delegate { progressBar.Visible = false; });
                });
                t1.Start();
            }
            else
            {
                MessageBox.Show("You did not select anything to create zip file!","Retry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //zip selections
    }
}
