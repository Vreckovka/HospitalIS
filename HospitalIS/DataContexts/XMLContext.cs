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
    public static class XmlContext
    {
        public static Pacients Pacients { get; set; }
        public static string XmlPath { get; } = "..\\..\\pacients.xml";
        static XmlContext()
        {
            DeserializedPacients();
        }

        public static void SerializePacients()
        {
            using (FileStream stream = new FileStream(XmlPath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                xmlSerializer.Serialize(stream, Pacients);

            }
        }
        public static void DeserializedPacients()
        {
            if (File.Exists(XmlPath))
                using (FileStream stream = new FileStream(XmlPath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacients));
                    Pacients = (Pacients)xmlSerializer.Deserialize(stream);
                }
            else
            {
                SerializePacients();
                DeserializedPacients();
            }
        }
    }
}
