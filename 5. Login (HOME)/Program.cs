using System;

namespace _5._Login__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			bool ok = false;

			int counter = 0;

			while (true)
			{
				counter++;
				string reversed = Console.ReadLine();

				for (int i = 0; i < password.Length; i++)
				{
					if (password[i] == reversed[password.Length - 1 - i])
					{
						Console.WriteLine("User Acer logged in.");
						ok = true;
						break;
					}
				}

				if (counter == 4)
				{
					Console.WriteLine($"User {password} blocked!");
					break;
				}

				if (ok)
				{
					break;
				}

				
			}

		}
	}
}
