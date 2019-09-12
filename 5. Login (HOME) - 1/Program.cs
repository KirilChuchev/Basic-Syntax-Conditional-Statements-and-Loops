using System;

namespace _5._Login__HOME____1
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();




			string reversed = string.Empty;
			int counter = 0;

			int length = username.Length;

			for (int i = 0; i < length; i++)
			{
				reversed += "" + username[length - 1 - i];
			}

			while (true)
			{
				string password = Console.ReadLine();
				counter++;
				

				if (password == reversed)
				{
					Console.WriteLine($"User {username} logged in.");
					break;
				}
				else
				{
					if (counter < 4)
					{
						Console.WriteLine("Incorrect password. Try again.");
					}
					else
					{
						Console.WriteLine($"User {username} blocked!");
						break;
					}
					
					

				}

				

			}
		}
	}
}
