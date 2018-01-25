using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Pic.DAL.SQLite;
using Pic.Plugin;
using Sharp3D.Math;
using System.Windows.Forms;
using Pic.Plugin.ViewCtrl;
using System.IO;
using Pic.Plugin.GeneratorCtrl;
using System.Xml;
using System.Xml.Linq;

namespace Interface_Nicolas
{
    class Program
    {
        
        static void Main(string[] args)
        {

            View View = new View();
            LoadComponents loadComp = new LoadComponents();
            loadComp.LoadListComponent();
            loadComp.PluginLoadComponent(View);
                      
            Application.Run(View);

            Console.ReadLine();
        }

        

        
       
    }
}
