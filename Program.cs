using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;
using System.IO;

namespace Interface_Nicolas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string directoryPath = Path.Combine(Application.StartupPath, @"CompDownloader\");

            //Initialise application
            LoadComponents loadComp = new LoadComponents();
            componentList compList =  loadComp.LoadListComponent();
            
            LoadPlugin loadPlug = new LoadPlugin(directoryPath, compList);
            View View = new View(directoryPath,compList, loadPlug);
            loadPlug.PluginLoadComponent(View, "F_0201");
            
            Application.Run(View);

            Console.ReadLine();
        }
    }
}
