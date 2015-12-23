using System;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var hellos = new IHelloWorld[] 
            {
                new HelloWorldWithRecursive(),
                new HelloWorldWithAggregate(),
                new DesignTimeGeneratedClassA(),
                new DesignTimeGeneratedClassB(),
                new DesignTimeGeneratedClassC(),
            };

            try
            {
                foreach (var hello in hellos)
                {
                    hello.Hello(args);
                    //hello.Hello(null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
