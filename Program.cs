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


namespace Interface_Nicolas
{
    class Program
    {
        
        static void Main(string[] args)
        {


            DLL dll = new DLL();

            

            IComponentSearchMethod searchMethod = new ComponentSearchDirectory(Path.Combine(Path.GetTempPath(), "Library"));
            
            //string ModeleName = "51d3dae8_1231_40ab_9f17_7a8cbfe0a0c7.dll";
            String ModeleName = "00d91bb4_d9ac_41f1_956b_42969850bbd2.dll";
            //String ModeleName = "33102fa0_dbe4_4efe_a7df_69eb64a6a242.dll";

            Pic.Plugin.Component currentComponent = dll.GetComponent(ModeleName);
            
            Console.WriteLine("Component Path : " + searchMethod.GetFilePathFromGuid(currentComponent.Guid));
            ParameterStack stack = currentComponent.BuildParameterStack(null);

            //plug1.HasDependancies = currentComponent.GetDependancies(stack).Count > 0;

            //Console.WriteLine("dep du polugin : " + plug1.HasDependancies);

            Console.WriteLine("Component Name : " + currentComponent.Name);
            Console.WriteLine("Component Guid : " + currentComponent.Guid);
            Console.WriteLine("version : " + currentComponent.Version);
          
            //Console.WriteLine("Dépendances : " + currentComponent.GetDependancies(pStack).Count);
            
            //List<Guid> list = currentComponent.GetDependancies(pStack);
            
            Form1 form1 = new Form1();
            form1.LoadComponent(currentComponent);
            Application.Run(form1);

            Console.ReadLine();
        }

        
       
    }
}
