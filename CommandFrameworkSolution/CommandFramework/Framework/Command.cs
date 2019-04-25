using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommandFramework.Utils;
using CommandFramework.Framework.Attributes;
using CommandFramework.Framework.Objects;

namespace CommandFramework.Framework
{
    class Command
    {
        public readonly string name;

        private Type commandType;
        private object commandObject;

        private Dictionary<MethodInfo, SubInfo> methods = new Dictionary<MethodInfo, SubInfo>();

        public Command(Type type)
        {
            commandType = type;

            commandObject = Activator.CreateInstance(commandType);

            name = ReflectionUtil.GetTypeAttributeValue<CommandAttribute, string>(commandType, "Value");

            foreach (MethodInfo method in ReflectionUtil.GetMethodsWithAttribute<SubAttribute>(commandType))
            {
                SubInfo subInfo = new SubInfo
                {
                    Name = name,
                    MethodName = method.Name.ToLower(),
                    Usage = ReflectionUtil.GetMethodAttributeValue<UsageAttribute, string>(method, "Value"),
                    Description = ReflectionUtil.GetMethodAttributeValue<DescriptionAttribute, string>(method, "Value"),
                    MinArgs = ReflectionUtil.GetMethodAttributeValue<MinArgsAttribute, int>(method, "Value")
                };

                Console.WriteLine("Usage: " + subInfo.Usage);

                methods.Add(method, subInfo);
            }

        }

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                // Show help message
                Console.WriteLine("Help for command '" + name + "':");

                foreach (SubInfo info in methods.Values)
                {
                    Console.WriteLine(info.GetInfo());
                }

                return;
            }

            MethodInfo method = null;
            SubInfo subInfo = null;

            foreach (KeyValuePair<MethodInfo, SubInfo> subMethod in methods)
            {
                if (subMethod.Key.Name.ToLower() == args[0].ToLower())
                {
                    method = subMethod.Key;
                    subInfo = subMethod.Value;
                    break;
                }
            }

            if (method == null)
            {
                // Throw exception cannot find sub command
                Console.WriteLine("Cannot find that sub command.");
                return;
            }

            if (args.Length < subInfo.MinArgs)
            {
                // Throw Min args exception

                Console.WriteLine("Not enough args.");
                return;
            }

            method.Invoke(commandObject, args);
        }
    }
}
