using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandFramework.Framework;
using CommandFramework.Commands;
using CommandFramework.Framework.Handlers;
using System.Reflection;
using System.IO;

namespace CommandFramework
{
    class Program
    {
        public static void Main(string[] args)
        {
            CommandHandler cmdHandler = new CommandHandler(Assembly.GetExecutingAssembly());



            while (true)
            {

                Console.WriteLine("Give command: ");

                string input = Console.ReadLine();

                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
                if (input.ToLower().Equals("stop")) return;

                cmdHandler.HandleCommand(input);
            }

        }
    }
}
