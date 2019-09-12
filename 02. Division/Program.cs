using System;

namespace _02._Division
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int counter = 0;

			for (int i = 10; i >= 2; i--)
			{
				if (i == 10 || i == 7 || i == 6 || i == 3 || i == 2)
				{
					if (number % i == 0)
					{
						Console.WriteLine($"The number is divisible by {i}");
						break;

					}
					else
					{
						counter++;

						if (counter >= 5)
						{
							Console.WriteLine("Not divisible");
							break;
						}
						else
						{
							continue;
						}
						
					}

					
				}
			}
		}
	}
}
