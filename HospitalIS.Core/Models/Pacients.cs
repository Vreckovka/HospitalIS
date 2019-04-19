using System.Collections.Generic;
using System.Xml.Serialization;

namespace HospitalIS.Core.Models
{
    [XmlRoot("Pacients")]
    public class Pacients : List<Pacient>
    {
    }
}
