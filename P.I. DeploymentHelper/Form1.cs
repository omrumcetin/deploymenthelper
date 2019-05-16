using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P.I.DeploymentHelper
{
    public partial class form_welcome : Form
    {
        #region ClassVariables
        private bool windowMovable = false;
        private int mouseValueX;
        private int mouseValueY;
        private IEnumerable<string> files;
        private readonly string path = @"d:\Works\C\Customers\Qatar\pipelines\";
        #endregion
        public form_welcome()
        {
            InitializeComponent();
        }
        
        private void Form_welcome_Load(object sender, EventArgs e)
        {
            files = Directory.EnumerateFiles(path, "*.xml", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string fileName = file.Substring(path.Length);
                lb_source.Items.Add(fileName);
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
                if (rx.IsMatch(fileName))
                {
                    lb_source.Items.Add(fileName);
                }
                    
            }                        
        }
    }
}
