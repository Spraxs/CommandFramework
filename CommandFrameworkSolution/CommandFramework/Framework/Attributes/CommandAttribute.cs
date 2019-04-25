using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    class CommandAttribute : Attribute
    {
        public CommandAttribute(string commandName)
        {
            Value = commandName;
        }

        public string Value;
    }
}
