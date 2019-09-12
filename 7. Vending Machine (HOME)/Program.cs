using System;

namespace _7._Vending_Machine__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();

			

			double coin = 0;
			double sumInserted = 0;
			
			double productPrice = 0;

			while (command != "Start")
			{
				coin = double.Parse(command);

				if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
				{
					sumInserted += coin;
				}
				else
				{
					Console.WriteLine($"Cannot accept {coin}");
				}




				command = Console.ReadLine();
				
			}

			command = Console.ReadLine();



			while (command != "End")
			{
				switch (command)
				{
					case "Nuts":
						{
							productPrice = 2.0;

							if (sumInserted >= productPrice)
							{
								sumInserted = sumInserted - productPrice;
								Console.WriteLine("Purchased nuts");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
							
						}
						break;
					case "Water":
						{
							productPrice = 0.7;

							if (sumInserted >= productPrice)
							{
								sumInserted = sumInserted - productPrice;
								Console.WriteLine("Purchased water");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Crisps":
						{
							productPrice = 1.5;

							if (sumInserted >= productPrice)
							{
								sumInserted = sumInserted - productPrice;
								Console.WriteLine("Purchased crisps");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Soda":
						{
							productPrice = 0.8;

							if (sumInserted >= productPrice)
							{
								sumInserted = sumInserted - productPrice;
								Console.WriteLine("Purchased soda");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;
					case "Coke":
						{
							productPrice = 1.0;

							if (sumInserted >= productPrice)
							{
								sumInserted = sumInserted - productPrice;
								Console.WriteLine("Purchased coke");
							}
							else
							{
								Console.WriteLine("Sorry, not enough money");
							}
						}
						break;

					default:
						{
							Console.WriteLine("Invalid product");
						}
						break;
				}

				command = Console.ReadLine();
			}



			Console.WriteLine($"Change: {sumInserted:F2}");

		}
	}
}
