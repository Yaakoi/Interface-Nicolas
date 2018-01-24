using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pic.Plugin;
using Pic.Factory2D;
using Sharp3D.Math.Core;
using Pic.Plugin.ViewCtrl;
using System.IO;
using Pic.DAL.LibraryLoader;

namespace Interface_Nicolas
{
    class DLL
    {
        public Component GetComponent(string ModeleName)
        {
            //IComponentSearchMethod searchMethod = new ComponentSearchDirectory(Path.Combine(Path.GetTempPath(), "Library"));
            ComponentLoader componentLoader = new ComponentLoader();
            //componentLoader.SearchMethod = searchMethod;
            Component comp = componentLoader.LoadComponent(@"C:\Users\nmoreau\AppData\Local\Temp\Library\" + ModeleName);
            
            return comp;
        }

        public double GetParameters(Component comp, string paramName)
        {
            double x = comp.BuildParameterStack(null).GetDoubleParameterValue(paramName);
            return x;
        }
    }
}