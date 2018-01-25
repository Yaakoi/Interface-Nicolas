using Pic.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using Pic.Plugin.ViewCtrl;

namespace Interface_Nicolas
{
    class LoadComponents
    {
        componentList compList = new componentList();
        PluginViewCtrl pluginViewCtrl = new PluginViewCtrl();
        string directoryPath = @"C:\Users\nmoreau\Documents\Visual Studio 2015\Projects\Interface Nicolas\Interface Nicolas\CompDownloader\PackageList.xml"
        string compPath;

        public void LoadListComponent()
        {

            //Set the list of components
            XmlTextReader xmlr = new XmlTextReader(directoryPath);
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
        }

        public void PluginLoadComponent(View view)
        {
            IComponentSearchMethod searchMethod = new ComponentSearchDirectory(directoryPath);
           
            //Find component
            string aRechercher = "F_0300";
            componentListComponents matchComp = compList.components.Find(x => x.name == aRechercher);

            //Get filePath from Guid
            Guid compGuid = Guid.Parse(matchComp.guid);
            compPath = searchMethod.GetFilePathFromGuid(compGuid);

            
            //Load component in View
            ComponentLoader componentLoader = new ComponentLoader();
            componentLoader.SearchMethod = searchMethod;
            Component comp = componentLoader.LoadComponent(compPath);
            pluginViewCtrl.SearchMethod = searchMethod;
            view.LoadComponent(comp);

        }
    }
}
