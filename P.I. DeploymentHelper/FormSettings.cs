using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace P.I.DeploymentHelper
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        #region globalvariables
        int selectedIndex = 0;
        bool newEntry = false;
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
