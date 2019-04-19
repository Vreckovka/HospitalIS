using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HospitalIS.Models;

namespace Hospital.DataContexts
{
    
    public class XmlContext : IDataContext
    {
        public static Pacients Pacients { get; set; }
        public static string XmlPath { get; } = "..\\..\\pacients.xml";
        public XmlContext()
        {
            Load();
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(XmlPath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                xmlSerializer.Serialize(stream, Pacients);
            }
        }
        public void Load()
        {
            if (File.Exists(XmlPath))
                using (FileStream stream = new FileStream(XmlPath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                    Pacients = (Pacients)xmlSerializer.Deserialize(stream);
                }
            else
            {
                Save();
                Load();
            }
        }
    }
}
