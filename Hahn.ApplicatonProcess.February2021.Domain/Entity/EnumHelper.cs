using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hahn.ApplicatonProcess.February2021.Domain.Entity
{
    public static class EnumHelper
    {
        public static string EnumDescription(this System.Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
