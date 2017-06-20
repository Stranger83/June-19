using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigFactorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			BigInteger nFactorial = 1;

			for (int i = 2; i <= n; i++)
			{
				nFactorial *= i;
			}
			Console.WriteLine(nFactorial);
		}
	}
}
