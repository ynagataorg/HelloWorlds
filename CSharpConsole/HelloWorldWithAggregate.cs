using System;
using System.Linq;

namespace CSharpConsole
{
    class HelloWorldWithAggregate : HelloWorldBase
    {
        public override int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((a, b) => a * b);
        }
    }
}
