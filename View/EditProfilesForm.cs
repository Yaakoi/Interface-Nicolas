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
using Interface_Nicolas.Controller;
using Interface_Nicolas.Model;
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
            ProfileSearchXMLFile.XmlFilePath = @"C:\Users\nmoreau\Documents\Projet\Interface-Nicolas\Model\ProfileData.xml";
            MajoSearchXMLFile.XmlFilePath = @"C:\Users\nmoreau\Documents\Projet\Interface-Nicolas\Model\CompMajoByProfil.xml";
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

                foreach (profileListProfile prof in ProfileSearchXMLFile.Instance.ProfileList)
                { profileListView.Items.Add(new ListViewItem(prof.name)).Tag=prof; }


            }

            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }

        //Bouton "Sélectionner"
        private void button1_Click(object sender, EventArgs e)
        {
            
         
                
        }

        //Bouton "Annuler"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected static ILog _log = LogManager.GetLogger(typeof(MainForm));

        private void button1_Click_1(object sender, EventArgs e)
        {
            profileListProfile p = (profileListProfile)profileListView.SelectedItems[0].Tag;
            MajorationCtrl majoCtrl = new MajorationCtrl(_pluginViewCtrl, p.code);
            majoCtrl.setMajoCurrentComponent();
            
        }
    }
}
