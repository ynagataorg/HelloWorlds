using System;
using System.Linq;

namespace CSharpConsole
{

	/// <summary>
	/// デザイン時コード生成を試してみます。
	/// </summary>
	/// <remarks>
	/// [T4 テキスト テンプレートを使用したデザイン時コード生成](https://msdn.microsoft.com/ja-jp/library/dd820620.aspx)
	/// </remarks>
	public partial class DesignTimeGeneratedClassA
	{
		internal static void Run(string[] args)
		{
			Console.WriteLine("Hello, World! @ {0}", DateTime.Now);
			Console.WriteLine("5! == {0}", DesignTimeGeneratedClassA.Factorial(5));
			Console.WriteLine("10! == {0}", DesignTimeGeneratedClassA.Factorial2(10));
		}

		private static uint Factorial(uint n)
		{
			return n == 0 ? 1 : n * DesignTimeGeneratedClassA.Factorial(n - 1);
		}

		private static uint Factorial2(uint n)
		{
			return n > int.MaxValue 
				? uint.MaxValue
				: (uint)Enumerable.Range(1, (int)n).Aggregate((a, b) => a * b);
		}
	}

	/// <summary>
	/// デザイン時コード生成を試してみます。
	/// </summary>
	/// <remarks>
	/// [T4 テキスト テンプレートを使用したデザイン時コード生成](https://msdn.microsoft.com/ja-jp/library/dd820620.aspx)
	/// </remarks>
	public partial class DesignTimeGeneratedClassB
	{
		internal static void Run(string[] args)
		{
			Console.WriteLine("Hello, World! @ {0}", DateTime.Now);
			Console.WriteLine("5! == {0}", DesignTimeGeneratedClassB.Factorial(5));
			Console.WriteLine("10! == {0}", DesignTimeGeneratedClassB.Factorial2(10));
		}

		private static uint Factorial(uint n)
		{
			return n == 0 ? 1 : n * DesignTimeGeneratedClassB.Factorial(n - 1);
		}

		private static uint Factorial2(uint n)
		{
			return n > int.MaxValue 
				? uint.MaxValue
				: (uint)Enumerable.Range(1, (int)n).Aggregate((a, b) => a * b);
		}
	}

	/// <summary>
	/// デザイン時コード生成を試してみます。
	/// </summary>
	/// <remarks>
	/// [T4 テキスト テンプレートを使用したデザイン時コード生成](https://msdn.microsoft.com/ja-jp/library/dd820620.aspx)
	/// </remarks>
	public partial class DesignTimeGeneratedClassC
	{
		internal static void Run(string[] args)
		{
			Console.WriteLine("Hello, World! @ {0}", DateTime.Now);
			Console.WriteLine("5! == {0}", DesignTimeGeneratedClassC.Factorial(5));
			Console.WriteLine("10! == {0}", DesignTimeGeneratedClassC.Factorial2(10));
		}

		private static uint Factorial(uint n)
		{
			return n == 0 ? 1 : n * DesignTimeGeneratedClassC.Factorial(n - 1);
		}

		private static uint Factorial2(uint n)
		{
			return n > int.MaxValue 
				? uint.MaxValue
				: (uint)Enumerable.Range(1, (int)n).Aggregate((a, b) => a * b);
		}
	}
}