using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface_Nicolas
{
    class LoadComponents
    {
        public void LoadListComponent()
        {

            componentList compList = new componentList();
            componentListComponents comp = new componentListComponents();
            XmlTextReader xmlr = new XmlTextReader(@"C:\Users\nmoreau\Documents\Visual Studio 2015\Projects\Interface Nicolas\Interface Nicolas\CompDownloader\PackageList.xml");
            while (xmlr.Read())
            {
                if (xmlr.NodeType == XmlNodeType.Element)
                {
                    if (xmlr.Name == "components")
                    {
                        comp.name = xmlr.GetAttribute("name");
                        comp.guid = xmlr.GetAttribute("guid");
                        comp.fileName = xmlr.GetAttribute("fileName");
                        comp.description = xmlr.GetAttribute("description");
                        compList.components.Add(comp);
                    }
                }
            }

            Console.WriteLine(compList.components.Count);

        }
    }
}
