using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandFramework.Framework.Exceptions
{
    class CommandAttributeMissingException : Exception
    {
        public CommandAttributeMissingException()
        {
            Console.WriteLine("Missing Command attribute");
        }

        public CommandAttributeMissingException(Type type)
        {
            Console.WriteLine("Missing Command attribute in class: '" + type.Name + "'!");
        }

        public CommandAttributeMissingException(string message) : base(message)
        {

        }

        public CommandAttributeMissingException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
