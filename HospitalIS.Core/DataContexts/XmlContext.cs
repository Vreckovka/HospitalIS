using System.IO;
using System.Xml.Serialization;
using HospitalIS.Core.Models;

namespace HospitalIS.Core.DataContexts
{
    public class XmlContext : DataContext
    {
        public static string XmlPath { get; } = "..\\..\\pacients.xml";
        public XmlContext()
        {
            Load();
        }

        public override void Save()
        {
            using (FileStream stream = new FileStream(XmlPath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                xmlSerializer.Serialize(stream, Pacients);
            }
        }
        public override void Load()
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
