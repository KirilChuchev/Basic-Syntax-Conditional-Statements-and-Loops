using System;

namespace _10._Rage_Expenses__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			int gamesCount = int.Parse(Console.ReadLine());
			double headsetPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displayPrice = double.Parse(Console.ReadLine());

			double totalExpense = 0;

			int headsetCount = 0;
			int mouseCount = 0;
			int keyboardCount = 0;
			int displayCount = 0;


			for (int i = 1; i <= gamesCount; i++)
			{
				if (i % 2 == 0)
				{
					headsetCount++;
				}

				if (i % 3 == 0)
				{
					mouseCount++;
				}

				if (i % 2 == 0 && i % 3 == 0)
				{
					keyboardCount++;
				}
			}

			displayCount = keyboardCount / 2;
			totalExpense = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

			Console.WriteLine($"Rage expenses: {totalExpense:F2} lv.");
		}
	}
}
