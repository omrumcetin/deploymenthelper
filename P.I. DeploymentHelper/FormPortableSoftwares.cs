using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace P.I.DeploymentHelper
{
    public partial class Form_PortableSoftwares : Form
    {
        public Form_PortableSoftwares()
        {
            InitializeComponent();
        }
        #region ClassVariables
        private bool windowMovable = false;
        private int mouseValueX;
        private int mouseValueY;
        int selectedIndex = 0;
        bool newEntry = false;
        #endregion
        #region Template
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void FormSettings_MouseUp(object sender, MouseEventArgs e)
        {
            windowMovable = false;
        }
        private void FormSettings_MouseDown(object sender, MouseEventArgs e)
        {
            windowMovable = true;
            mouseValueX = e.X;
            mouseValueY = e.Y;
        }
        private void FormSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (windowMovable)
            {
                this.SetDesktopLocation(MousePosition.X - mouseValueX, MousePosition.Y - mouseValueY);
            }
        }
        #endregion
        private void BttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            var customConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            ComboBoxPortables.Items.Clear();
            foreach (PortableConfigElement portableElement in customConfig.portables)
            {
                ComboBoxPortables.Items.Add(portableElement.name);
            }
            ComboBoxPortables.SelectedIndex = selectedIndex;
            newEntry = false;
        }
        private void ComboBoxPortables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var portableName = ComboBoxPortables.Text;
            var portablesConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            foreach (PortableConfigElement portableElement in portablesConfig.portables)
            {
                if(portableName == portableElement.name)
                {
                    TextboxName.Text = portableElement.name ?? "";
                    TextboxFilename.Text = portableElement.filename ?? "";
                    TextboxRemotePath.Text = portableElement.remotepath ?? "";
                    break;
                }
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var portableName = ComboBoxPortables.Text;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("tools.config");
            if (newEntry && portableName != null)
            {
                var newNode = xmlDoc.CreateElement("portable");
                newNode.SetAttribute("name", portableName);
                newNode.SetAttribute("filename", TextboxFilename.Text);
                newNode.SetAttribute("remotepath", TextboxRemotePath.Text);
                xmlDoc.SelectSingleNode("//tools/portables").AppendChild(newNode);
                xmlDoc.Save("tools.config");
                ConfigurationManager.RefreshSection("tools");
            }
            else if (!newEntry)
            {
                var singleNode = (XmlElement)xmlDoc.SelectSingleNode($"//tools/portables/portable[@name='{portableName}']");
                singleNode.SetAttribute("name", TextboxName.Text);
                singleNode.SetAttribute("filename", TextboxFilename.Text);
                singleNode.SetAttribute("remotepath", TextboxRemotePath.Text);
                xmlDoc.Save("tools.config");
                ConfigurationManager.RefreshSection("tools");
                selectedIndex = ComboBoxPortables.SelectedIndex;
            }
            FormSettings_Load(sender, e);

        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ComboBoxPortables_SelectedIndexChanged(sender,e);
        }
        private void ComboBoxPortables_TextChanged(object sender, EventArgs e)
        {
            var newEntryAttempt = true;
            TextboxName.Enabled = false;
            TextboxName.Text = "";
            var portableName = ComboBoxPortables.Text;
            var portablesConfig = (ToolsConfigSection)ConfigurationManager.GetSection("tools");
            foreach (PortableConfigElement portableElement in portablesConfig.portables)
            {
                if (portableName.Equals(portableElement.name, StringComparison.OrdinalIgnoreCase))
                {
                    newEntryAttempt = false;
                    TextboxName.Enabled = true;
                    TextboxName.Text = portableElement.name;
                    break;
                }
            }
            newEntry = newEntryAttempt;
        }
    }
}
