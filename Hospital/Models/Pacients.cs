using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PropertyChanged;

namespace HospitalIS.Models
{
    [AddINotifyPropertyChangedInterface]
    [XmlRoot("Pacients")]
    public class Pacients : List<Pacient>
    {
    }
}
