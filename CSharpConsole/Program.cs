using System;
using System.Linq;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Run(args);
            DesignTimeGeneratedClassA.Run(args);
            DesignTimeGeneratedClassB.Run(args);
            DesignTimeGeneratedClassC.Run(args);
        }

        internal static void Run(string[] args)
        {
            Console.WriteLine("Hello, World! @ {0}", DateTime.Now);
            Console.WriteLine("5! == {0}", Program.Factorial(5));
            Console.WriteLine("10! == {0}", Program.Factorial2(10));
        }

        private static uint Factorial(uint n)
        {
            return n == 0 ? 1 : n * Program.Factorial(n - 1);
        }

        private static uint Factorial2(uint n)
        {
            return n > int.MaxValue 
                ? uint.MaxValue
                : (uint)Enumerable.Range(1, (int)n).Aggregate((a, b) => a * b);
        }
    }
}
