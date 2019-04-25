using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    class MinArgsAttribute : Attribute
    {

        public MinArgsAttribute(int argsAmount)
        {

            Value = argsAmount;
        }

        public MinArgsAttribute()
        {

            Value = 0;
        }

        public int Value;
    }
}
