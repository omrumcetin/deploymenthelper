using System;
using System.Configuration;

namespace P.I.DeploymentHelper
{
    public class ToolsConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("portables")]
        public PropertyConfigElementCollection portables
        {
            get { return (PropertyConfigElementCollection)base["portables"]; }
        }
    }

    public class PortableConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }
        [ConfigurationProperty("filename")]
        public string filename
        {
            get { return (string)base["filename"]; }
            set { base["filename"] = value; }
        }
    }

    [ConfigurationCollection(typeof(PortableConfigElement), AddItemName = "portable")]
    public class PropertyConfigElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PortableConfigElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }
            return (PortableConfigElement)element;
        }
    }
}
