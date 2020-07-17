using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandFramework.Framework.Attributes;

namespace CommandFramework.Commands
{
    [Command("test")]
    class CommandTest
    {


        [Sub, MinArgs(0), Description("This is a debug command")]
        public void Debug()
        {
            Console.WriteLine("This is a [DEBUG] message!");
        }

        [Sub, MinArgs(1), Description("This is a message print command"), Usage("<message>")]
        public void Print(string msg)
        {
            Console.WriteLine("Message print: " + msg);
        }
    }
}
