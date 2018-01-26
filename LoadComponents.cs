#region Using directives
using Pic.Plugin;
using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;
#endregion

namespace Interface_Nicolas
{
    class LoadComponents
    {
        #region Data members
        private componentList compList = new componentList();
        string directoryPath = Path.Combine(Application.StartupPath, @"CompDownloader\");
        #endregion

        public componentList LoadListComponent()
        {
            //Set the list of components
            XmlTextReader xmlr = new XmlTextReader(directoryPath + @"PackageList.xml");
            while (xmlr.Read())
            {
                if (xmlr.NodeType == XmlNodeType.Element)
                {
                    if (xmlr.Name == "components")
                    {
                        componentListComponents comp = new componentListComponents();
                        comp.name = xmlr.GetAttribute("name");
                        comp.guid = xmlr.GetAttribute("guid");
                        comp.fileName = xmlr.GetAttribute("fileName");
                        comp.description = xmlr.GetAttribute("description");
                        compList.components.Add(comp);
                    }
                }
            }
            return compList;
        }

        

        public componentList GetComponentList
        {
            get{
                return compList;
            }
            set{
                compList = value;
            }
        }
    }
}
