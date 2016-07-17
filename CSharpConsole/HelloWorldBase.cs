using System;
using System.Collections.Generic;

namespace CSharpConsole
{
    internal abstract class HelloWorldBase : IHelloWorld
    {
        public abstract int Factorial(int n);

        public void Hello(string[] args)
        {
            Console.WriteLine($"[from {this.GetType().FullName}]");
            Console.WriteLine($"Hello, World! @ {DateTime.Now}");

            if (args == null)
            {
                return;
            }

            foreach (var arg in args.ToInt())
            {
                Console.WriteLine($"{arg}! == {this.Factorial(arg)}");
            }
        }
    }

    internal static class Extensions
    {
        internal static IEnumerable<int> ToInt(this IEnumerable<string> source)
        {
            foreach (var s in source)
            {
                int num;
                var result = int.TryParse(s, out num);
                yield return result ? num : 0;
            }
        }
    }

}
