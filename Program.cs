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
            View View = new View();
            LoadComponents loadComp = new LoadComponents();
            loadComp.LoadListComponent();
            loadComp.PluginLoadComponent(View);

           
            Application.Run(View);

            Console.ReadLine();
        }
    }
}
