using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			
			for(int i = 1; i <= n; i++)
			{
				for(int j = 1; j <= i; j++)
				{
					var c = i.ToString().ToCharArray();
					Console.Write($"{i} ");
				}
				Console.WriteLine();
			}
		}
	}
}
