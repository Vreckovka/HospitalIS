﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Shapes;
using HospitalIS.Core.Attributes;
using HospitalIS.Core.Models;
using HospitalIS.UserControls;

namespace HospitalIS.BindingSourceExtension
{
    public class EnumBindingSourceExtensionWithIcon : MarkupExtension
    {
        Type _enumType;
        public EnumBindingSourceExtensionWithIcon(Type enumType)
        {
            _enumType = enumType;
        }

        /// <summary>
        /// Provides list of MenuItemWithIcon from enum 
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var list = new List<MenuItemWithIcon>();
            
            //Gets enum type with reflection
            var type = _enumType.GetTypeInfo();

            foreach (Enum enumVal in Enum.GetValues(type))
            {
                list.Add(CreateMenuItem(enumVal));
            }

            return list;
        }

        /// <summary>
        /// Returns new MenuItemWithIcon class from enum 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private MenuItemWithIcon CreateMenuItem(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi != null)
            {
                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var icons = (IconStyleKey[])fi.GetCustomAttributes(typeof(IconStyleKey), false);

                var iconKey = ((icons.Length > 0) && (!String.IsNullOrEmpty(icons[0].IconKeyPath))) ? icons[0].IconKeyPath : value.ToString();
                Path icon = null;

                if (iconKey != null)
                    icon = (Path)Application.Current.Resources[iconKey];

                var name = ((attributes.Length > 0) && (!String.IsNullOrEmpty(attributes[0].Description))) ? attributes[0].Description : value.ToString();

                return new MenuItemWithIcon()
                {
                    Text = name,
                    Icon = icon,
                    MenuEnum = value
                };
            }

            return null;
        }
    }
}
