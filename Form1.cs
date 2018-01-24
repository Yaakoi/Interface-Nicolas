using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pic.Factory2D.Control;
using Pic.Plugin.ViewCtrl;
using Pic.DAL.SQLite;
using Pic.Plugin;
using System.IO;

namespace Interface_Nicolas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //LoadTreeview();
        }    

        public void LoadComponent(Pic.Plugin.Component comp)
        {
            pluginViewCtrl1.SearchMethod = new ComponentSearchDirectory(Path.Combine(Path.GetTempPath(), "Library"));
            pluginViewCtrl1.Component = comp;
        }

        /*private void LoadTreeview()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("FEFCO");
            treeView1.Nodes[0].Nodes.Add("200");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("200");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("202");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("203");
            treeView1.Nodes[0].Nodes.Add("900");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("900");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("901");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("902");
            treeView1.EndUpdate();
            treeView1.Nodes[0].Nodes[0].Nodes[0].Name = "b60455f2_5d58_4cff_a80e_70288f0a87f8.dll";
            treeView1.Nodes[0].Nodes[0].Nodes[1].Name = "00d91bb4_d9ac_41f1_956b_42969850bbd2.dll";
            treeView1.Nodes[0].Nodes[1].Nodes[0].Name = "51d3dae8_1231_40ab_9f17_7a8cbfe0a0c7.dll";
        }
        */

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pluginViewCtrl1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       



        
    }
}
