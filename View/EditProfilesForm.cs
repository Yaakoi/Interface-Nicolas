using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using log4net;
using Pic.Plugin;
using Pic.Plugin.ViewCtrl;

namespace Interface_Nicolas
{
    public partial class EditProfilesForm : Form
    {

        PluginViewCtrl _pluginViewCtrl;
        public EditProfilesForm(PluginViewCtrl pluginViewCtrl)
        {
            InitializeComponent();

            _pluginViewCtrl = pluginViewCtrl;
            ProfileListView();
        }

        public void ProfileListView()
        {
            try
            {
                profileListView.View = View.Details;
                profileListView.FullRowSelect = true;
                profileListView.GridLines = true;
                profileListView.Sorting = SortOrder.Ascending;
                profileListView.Columns.Add("Profils", -2, HorizontalAlignment.Left);
                
                XmlTextReader reader = new XmlTextReader("ProfileData.xml");
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name.Equals("type"))
                        {
                            profileListView.Items.Add(new ListViewItem(reader.GetAttribute("name")));
                        }
                    }
                }
                

            }

            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }

        protected static ILog _log = LogManager.GetLogger(typeof(MainForm));
    }
}
