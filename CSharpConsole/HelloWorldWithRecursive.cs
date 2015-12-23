using System;

namespace CSharpConsole
{
    class HelloWorldWithRecursive : HelloWorldBase
    {
        public override int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return n == 0 ? 1 : n * this.Factorial(n - 1);
        }
    }
}
