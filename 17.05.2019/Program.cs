using System;

namespace _17._05._2019
{
	class Program
	{
		static void Main(string[] args)
		{
			int people = int.Parse(Console.ReadLine());
			string type = Console.ReadLine();
			string day = Console.ReadLine();

			double price = 0;
			double sum = 0;

			switch (type)
			{
				case "Students":
					{
						switch (day)
						{
							case "Friday":
								{
									price = 8.45;
									
								}
								break;
							case "Saturday":
								{
									price = 9.8;
									
								}
								break;
							case "Sunday":
								{
									price = 10.46;
								}
								break;

							default:
								break;
						}

						sum = price * people;

						if (people >= 30)
						{
							sum *= 0.85;
						}
					}
					break;
				case "Business":
					{
						switch (day)
						{
							case "Friday":
								{
									price = 10.9;

								}
								break;
							case "Saturday":
								{
									price = 15.6;

								}
								break;
							case "Sunday":
								{
									price = 16.0;
								}
								break;

							default:
								break;
						}

						

						if (people >= 100)
						{
							sum = price * (people - 10);
						}
						else
						{
							sum = price * people;
						}
					}
					break;
				case "Regular":
					{
						switch (day)
						{
							case "Friday":
								{
									price = 15.0;

								}
								break;
							case "Saturday":
								{
									price = 20.0;

								}
								break;
							case "Sunday":
								{
									price = 22.5;
								}
								break;

							default:
								break;
						}

						sum = price * people;

						if (people >= 10 && people <= 20)
						{
							sum *= 0.95;
						}
					}
					break;
				default:
					break;
			}


			Console.WriteLine("Total price: {0:F2}", sum);
		}
	}
}
