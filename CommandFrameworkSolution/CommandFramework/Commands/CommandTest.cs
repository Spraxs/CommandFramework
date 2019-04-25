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


        [Sub, MinArgs(0), Description("Dit is een test commando!"), Usage("Hallo ")]
        public void Create()
        {

        }

        [Sub]
        public void Nig()
        {

        }
    }
}
