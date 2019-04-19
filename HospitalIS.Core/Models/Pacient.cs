using System;
using System.Xml.Serialization;
using PropertyChanged;

namespace HospitalIS.Core.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Pacient
    {
        [XmlAttribute]
        public string PID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }

        public int Age
        {
            //365.242199 avrage lenght of years in gregorian calendar
            get { return (int) ((DateTime.Today - BirthDate).TotalDays / 365.242199); }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
