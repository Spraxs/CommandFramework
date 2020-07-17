using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    class UsageAttribute : Attribute
    {

        public UsageAttribute(string usage)
        {
            Value = usage;
        }

        public UsageAttribute()
        {
            Value = null;
        }

        public string Value;
    }
}
