using System;

namespace _6._Strong_Number__Home_
{
	class Program
	{
		static void Main(string[] args)
		{
			string numberS = Console.ReadLine();

			int length = numberS.Length;

			int number = int.Parse(numberS);

			int sum = 0;

			int factoriel = 1;


			for (int i = 1; i <= length; i++)
			{
				int digit = int.Parse(numberS[i-1].ToString());

				for (int j = 1; j <= digit; j++)
				{
					factoriel *= j;
				}

				sum += factoriel;

				factoriel = 1;
			}

			if (number == sum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
			
				
		}
	}
}
