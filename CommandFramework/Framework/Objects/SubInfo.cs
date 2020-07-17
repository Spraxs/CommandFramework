using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Objects
{
    class SubInfo
    {

        public string Name
        {
            get;
            set;
        }

        public string MethodName
        {
            get;
            set;
        }

        public string Usage
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int MinArgs
        {
            get;
            set;
        }

        public string GetInfo()
        {
            return Name + " " + MethodName + (Usage == null ? "" : " " + Usage) + " | " + Description;
        }

    }
}
