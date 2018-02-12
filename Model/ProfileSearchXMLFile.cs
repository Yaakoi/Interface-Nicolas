using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interface_Nicolas
{
    class ProfileSearchXMLFile
    {
        private List<profileListProfile> _listProfile;

        private static ProfileSearchXMLFile _instance;
        private static string _xmlFilePath;

        private ProfileSearchXMLFile(string filePath)
        {
            profileList lProfile = profileList.LoadFromFile(filePath);
            _listProfile = lProfile.profile.OrderBy(o => o.name).ToList();
        }

        public List<profileListProfile> ProfileList => _listProfile;

        public int getIdFromName(string name)
        {
            try
            {
                profileListProfile cp = _listProfile.Find(c => c.name == name);
                return cp.id;
            }
            catch (Exception /*ex*/)
            {
                return 0;
            }
        }

        public static ProfileSearchXMLFile Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new ProfileSearchXMLFile(_xmlFilePath);
                return _instance;
            }
        }
        public static string XmlFilePath
        {
            set
            {
                _xmlFilePath = value;
                if (!File.Exists(_xmlFilePath))
                    throw new FileNotFoundException(_xmlFilePath);
            }
        }

    }
}
