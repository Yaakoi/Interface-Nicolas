using Pic.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Nicolas
{
    public class LoadPlugin
    {
        String _directoryPath;
        componentList _compList;
        public LoadPlugin(String directoryPath, componentList compList)
        {
            _directoryPath = directoryPath;
            _compList = compList;
        }

        public void PluginLoadComponent(View view, String searchedComp)
        {
            IComponentSearchMethod searchMethod = new ComponentSearchDirectory(_directoryPath);

            if (searchedComp != null)
            {
                //Find component
                componentListComponents matchComp = _compList.components.Find(x => x.name == searchedComp);
                Guid compGuid = Guid.Parse(matchComp.guid);

                //Load component in View
                ComponentLoader componentLoader = new ComponentLoader();
                componentLoader.SearchMethod = searchMethod;

                Component comp = componentLoader.LoadComponent(searchMethod.GetAssemblyBytesFromGuid(compGuid));
                ParameterStack pStack = new ParameterStack();
                ParameterStack pStack1 = comp.BuildParameterStack(pStack);
                Console.WriteLine("L = " + pStack1.GetDoubleParameterValue("L"));
                Console.WriteLine("B = " + pStack1.GetDoubleParameterValue("B"));
                Console.WriteLine("H = " + pStack1.GetDoubleParameterValue("H"));
                view.LoadComponent(comp);
            }
        }
    }
}
