using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var number = int.Parse(Console.ReadLine());
				Console.WriteLine("It is a number.");
			}
			catch
			{
				Console.WriteLine("Invalid input!");
			}
		}
	}
}
