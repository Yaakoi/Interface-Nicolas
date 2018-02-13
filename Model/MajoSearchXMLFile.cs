using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Nicolas.Model
{
    class MajoSearchXMLFile
    {
        private List<MajoSetsFefco> _listMajoSets;

        private static MajoSearchXMLFile _instance;
        private static string _xmlFilePath;

        private MajoSearchXMLFile(string filePath)
        {
            MajoSets lMajo = MajoSets.LoadFromFile(filePath);
            _listMajoSets = lMajo.fefco.OrderBy(o => o.modele).ToList();
        }

        public List<MajoSetsFefco> MajoSet => _listMajoSets;

        public MajoSetsFefco getMajo(string modele, string profilCarton)
        {
            try
            {
                MajoSetsFefco cp = _listMajoSets.Find(c => (c.modele == modele) && (c.profilCarton == profilCarton));
               
                return cp;
            }
            catch (Exception /*ex*/)
            {
                return null;
            }
        }

        public static MajoSearchXMLFile Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new MajoSearchXMLFile(_xmlFilePath);
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
