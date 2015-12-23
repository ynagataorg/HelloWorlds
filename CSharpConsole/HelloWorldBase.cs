using System;
using System.Linq;

namespace CSharpConsole
{
    internal abstract class HelloWorldBase : IHelloWorld
    {
        public abstract int Factorial(int n);

        public void Hello(string[] args)
        {
            Console.WriteLine("[from {0}]", this.GetType().FullName);
            Console.WriteLine("Hello, World! @ {0}", DateTime.Now);

            if (args == null)
            {
                return;
            }

            foreach (var arg in args)
            {
                int parsed;
                if (int.TryParse(arg, out parsed))
                {
                    Console.WriteLine("{0}! == {1}", parsed, this.Factorial(parsed));
                }
            }
        }
    }
}
