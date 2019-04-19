using System;

namespace HospitalIS.Core.Attributes
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
