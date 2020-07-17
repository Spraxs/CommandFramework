using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    class DescriptionAttribute : Attribute
    {
        public DescriptionAttribute(string description)
        {
            Value = description;
        }

        public string Value;
    }
}
