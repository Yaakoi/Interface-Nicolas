using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pic.Plugin;

using System.Xml;

using log4net;
using Pic.Factory2D;

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
                pluginViewCtrl.PluginPath = ComponentSearchXMLFile.Instance.GetComponentPathFromName(searchedComp);
                pluginViewCtrl.ProfileLoader = new LoadProfile();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }


        

        private void propriétésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                
                PropertiesForm propForm = new PropertiesForm(pluginViewCtrl);
               
                propForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }

        }

        private void symetrieXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pluginViewCtrl.ReflectionX = !pluginViewCtrl.ReflectionX;
            pluginViewCtrl.Refresh();
        }

        private void symetrieYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pluginViewCtrl.ReflectionY = !pluginViewCtrl.ReflectionY;
            pluginViewCtrl.Refresh();
        }

        private void profilsCartonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                EditProfilesForm profilesForm = new EditProfilesForm(pluginViewCtrl);

                profilesForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }

        }
        protected static ILog _log = LogManager.GetLogger(typeof(MainForm));
    }
}
