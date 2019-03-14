using System;

class InstructionSet_broken
{
	static void Main()
	{

		while (true)
		{
			string opCode = Console.ReadLine();
			string[] codeArgs = opCode.Split(' ');

			long result = 0;

			if (opCode.Equals("END"))
			{
				break;
			}
			switch (codeArgs[0])
			{
				case "INC":
					{
						long operandOne = long.Parse(codeArgs[1]);
						operandOne++;
						result = operandOne;
						break;
					}
				case "DEC":
					{
						long operandOne = long.Parse(codeArgs[1]);
						operandOne--;
						result = operandOne;
						break;
					}
				case "ADD":
					{
						long operandOne = long.Parse(codeArgs[1]);
						long operandTwo = long.Parse(codeArgs[2]);
						result = operandOne + operandTwo;
						break;
					}
				case "MLA":
					{
						long operandOne = long.Parse(codeArgs[1]);
						long operandTwo = long.Parse(codeArgs[2]);
						result = operandOne * operandTwo;
						break;
					}
			}
			Console.WriteLine(result);
		}
	}
}
