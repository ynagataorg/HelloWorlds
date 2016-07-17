using System;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * デザイン時テンプレート、実行時テンプレートともに、下記サイトを大きく参考にしている
             * [Visual Studio搭載のT4テンプレートエンジンの3通りの活用方法 - seraphyの日記](http://d.hatena.ne.jp/seraphy/20140419)
             */

            // デザイン時テンプレート
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

            //// 実行時テンプレート
            //var instance = new RuntimeTemplate();
            //instance.ClassNames = new[] { "RuntimeGeneratedClassA", "RuntimeGeneratedClassB", };
            //var generatedText = instance.TransformText();
            //System.Diagnostics.Debug.WriteLine(generatedText);
            //Console.WriteLine(generatedText);
        }
    }
}
