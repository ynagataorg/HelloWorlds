using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetCoreConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 中身は CSharpConsole/HelloWorldWithAggregate とほぼ同一

            Console.WriteLine($"Hello, World! @ {DateTime.Now}");

            var nums = args.Length != 0
                ? args.ToInt().ToArray()
                : new[] {5, 10};
            foreach (var num in nums)
            {
                Console.WriteLine($"{num}! = {Program.Fact(num)}");
            }
        }

        private static int Fact(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((i, j) => i * j);
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
