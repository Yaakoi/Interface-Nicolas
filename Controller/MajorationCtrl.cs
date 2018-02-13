using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_Nicolas.Model;
using Pic.Plugin.ViewCtrl;
namespace Interface_Nicolas.Controller
{
    class MajorationCtrl
    {
        PluginViewCtrl _pluginViewCtrl;
        string _codeProfile;
        public MajorationCtrl(PluginViewCtrl pluginViewCtrl, string codeProfile)
        {
            _pluginViewCtrl = pluginViewCtrl;
            _codeProfile = codeProfile;
        }

        //set les param du current modele
        public void setMajoCurrentComponent()
        {
            MajoSetsFefco majoSetsFefco = MajoSearchXMLFile.Instance.getMajo(_pluginViewCtrl.Component.Name.Substring(3),_codeProfile);
          

        }

        //si la majoSet n'existe pas, la créer par interpolation
        //et l'insérer dans le fichier xml


    }
}
