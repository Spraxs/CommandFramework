using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommandFramework.Utils;
using CommandFramework.Framework.Attributes;

namespace CommandFramework.Framework.Handlers
{
    class CommandHandler
    {

        private Assembly assembly;

        private List<Command> commands = new List<Command>();

        public CommandHandler(Assembly _assembly)
        {
            assembly = _assembly;
            InitCommands();
        }

        private void InitCommands()
        {

            foreach (Type type in assembly.GetTypes())
            {
                CommandAttribute commandAttribute = ReflectionUtil.GetAttributeFromType<CommandAttribute>(type);

                if (commandAttribute == null) continue;

                Console.WriteLine("Loading '" + type.Name + "'...");

                commands.Add(new Command(type));

                Console.WriteLine("Loaded '" + type.Name + "'.");
            }
        }

        public void HandleCommand(string inputLine)
        {
            List<string> args = inputLine.Split(' ').ToList();

            if (args[0].Length == 0) return;

            foreach (Command command in commands)
            {
                if (command.name.ToLower().Equals(args[0].ToLower()))
                {
                    args.RemoveAt(0);

                    command.Execute(args.ToArray<string>());

                    break;
                }
            }
        }

    }
}
