using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;

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
        #endregion
        public form_welcome()
        {
            InitializeComponent();
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
            var customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            foreach (PortableConfigElement portableElement in customConfig.portables)
            {
                lb_portableSource.Items.Add(portableElement.name);
                portables.Add(portableElement.name);
            }




            //var value = ConfigurationSettings.AppSettings["TOAD"].ToString();
            //var portableSoftwareSettings = Properties.Settings.Default.PortableSoftwares;
            //portables = portableSoftwareSettings.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList();

            //lb_portableSource.Items.AddRange(portables.ToArray());

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

        private void Form_welcome_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Pipelines");
            Directory.CreateDirectory("PortableSoftwares");

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
