﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using HospitalIS.Core.Attributes;
using HospitalIS.Core.Models;

namespace HospitalIS.BindingSourceExtension
{
    public class EnumBindingSourceExtensionWithoutIcon : MarkupExtension
    {
        Type _enumType;
        public EnumBindingSourceExtensionWithoutIcon(Type enumType)
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
            if (null == this._enumType)
                throw new InvalidOperationException("The EnumType must be specified.");

            Type actualEnumType = Nullable.GetUnderlyingType(this._enumType) ?? this._enumType;
            Array enumValues = Enum.GetValues(actualEnumType);

            if (actualEnumType == this._enumType)
                return enumValues;

            Array tempArray = Array.CreateInstance(actualEnumType, enumValues.Length + 1);
            enumValues.CopyTo(tempArray, 1);
            return tempArray;
        }
    }
}

