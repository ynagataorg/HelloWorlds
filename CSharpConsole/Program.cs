using System;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! @ {0}", DateTime.Now);
            Console.WriteLine("5! == {0}", Program.Factorial(5));

            // 次の行はコンパイル前に VS が叱ってくれる。
            // var x = Program.Factorial(-1);
        }

        private static uint Factorial(uint n)
        {
            return n == 0 ? 1 : n * Program.Factorial(n - 1);
        }
    }
}
