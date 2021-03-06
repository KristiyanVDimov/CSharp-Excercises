using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
	class Factorial
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			BigInteger factorial = GetFactorial(number);

			Console.WriteLine(factorial);
		}

		private static BigInteger GetFactorial(int number)
		{
			BigInteger factorial = 1;

			for(int i = 1; i <= number; i++)
			{
				factorial *= i;
			}
			return factorial;
		}
	}
}
