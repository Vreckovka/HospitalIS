using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hospital.Models
{
    public static class LoadedPacients
    {
        public static Pacients Pacients { get; set; }
        public static string XMLPath { get; } = "..\\..\\pacients.xml";
        static LoadedPacients()
        {
            DeserializedPacients();
        }

        public static void SerializePacients()
        {
            using (FileStream stream = new FileStream(XMLPath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                xmlSerializer.Serialize(stream, Pacients);

            }
        }
        public static void DeserializedPacients()
        {
            using (FileStream stream = new FileStream(XMLPath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                Pacients = (Pacients)xmlSerializer.Deserialize(stream);
            }
        }
    }
}
