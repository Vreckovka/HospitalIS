using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalIS.Attributes
{
    /// <summary>
    /// Attribute for key in styles for icon
    /// </summary>
    // This defaults to Inherited = true.
    public class IconStyleKey : Attribute
    {
        public string IconKeyPath { get; set; }

        public IconStyleKey(string iconKey)
        {
            IconKeyPath = iconKey;
        }
    }
}
