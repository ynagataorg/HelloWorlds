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
	internal partial class DesignTimeGeneratedClassA : HelloWorldBase
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

	/// <summary>
	/// デザイン時コード生成を試してみます。
	/// </summary>
	/// <remarks>
	/// [T4 テキスト テンプレートを使用したデザイン時コード生成](https://msdn.microsoft.com/ja-jp/library/dd820620.aspx)
	/// </remarks>
	internal partial class DesignTimeGeneratedClassB : HelloWorldBase
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

	/// <summary>
	/// デザイン時コード生成を試してみます。
	/// </summary>
	/// <remarks>
	/// [T4 テキスト テンプレートを使用したデザイン時コード生成](https://msdn.microsoft.com/ja-jp/library/dd820620.aspx)
	/// </remarks>
	internal partial class DesignTimeGeneratedClassC : HelloWorldBase
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
