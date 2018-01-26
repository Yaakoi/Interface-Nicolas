using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pic.Plugin;

using System.Xml;



namespace Interface_Nicolas
{
    public partial class View : Form
    {
        componentList _compList;
        string _directoryPath;
        
        public View(string directoryPath, componentList compList)
        {
            InitializeComponent();
            _directoryPath = directoryPath;
            _compList = compList;
            ComponentListView();
            
            //LoadTreeview();
        }


        public void LoadComponent(Component comp)
        {
           pluginViewCtrl1.Component = comp;
        }

        public void ComponentListView()
        {

            XmlTextReader xmlr = new XmlTextReader(@"C:\Users\nmoreau\Documents\Visual Studio 2015\Projects\Interface Nicolas\Interface Nicolas\CompDownloader\PackageList.xml");
            
            // Set the view to show details.
            listView1.View = System.Windows.Forms.View.Details;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.


            
            List<componentListComponents> compListComp = _compList.components;

            //fill the list of items with component from xml file
            ListViewItem[] listItem = new ListViewItem[469];
            int i = 0;
            foreach (componentListComponents comp in compListComp)
            {
                listItem[i] = new ListViewItem(comp.name);
                i++;
            }
            
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("FEFCO", -2, HorizontalAlignment.Left);
            

            //Add the items to the ListView.
            listView1.Items.AddRange(listItem);


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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            LoadPlugin loadPlug = new LoadPlugin(_directoryPath, _compList);
            loadPlug.PluginLoadComponent(this, listView1.SelectedItems[0].Text);
            //MessageBox.Show(listView1.SelectedItems[0].Text);
        }
    }
}
