using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pic.Plugin;

using System.Xml;

using log4net;

namespace Interface_Nicolas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            ComponentSearchXMLFile.XmlFilePath = Properties.Settings.Default.XmlFilePath;

            InitializeComponent();

            ComponentListView();
        }

        public void LoadComponent(Component comp)
        {
           pluginViewCtrl.Component = comp;
        }

        public void ComponentListView()
        {
            try
            {
                // Set the view to show details.
                listView.View = View.Details;
                // Select the item and subitems when selection is made.
                listView.FullRowSelect = true;
                // Display grid lines.
                listView.GridLines = true;
                // Sort the items in the list in ascending order.
                listView.Sorting = SortOrder.Ascending;
                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView.Columns.Add("FEFCO", -2, HorizontalAlignment.Left);
                //fill the list of items with component from xml file
                foreach (component comp in ComponentSearchXMLFile.Instance.ComponentList)
                { listView.Items.Add(new ListViewItem(comp.name)); }
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string searchedComp = listView.SelectedItems[0].Text;
                pluginViewCtrl.SearchMethod = ComponentSearchXMLFile.Instance;
                pluginViewCtrl.PluginPath = ComponentSearchXMLFile.Instance.GetComponentPathFromName(listView.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }

        protected static ILog _log = LogManager.GetLogger(typeof(MainForm));
    }
}
