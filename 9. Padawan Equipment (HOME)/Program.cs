using System;

namespace _9._Padawan_Equipment__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			double lightsabersPrice = double.Parse(Console.ReadLine());
			double robesPrice = double.Parse(Console.ReadLine());
			double beltsPrice = double.Parse(Console.ReadLine());

			double totalPrice = 0;


			totalPrice = Math.Ceiling(students * 1.1) * lightsabersPrice + (students - (students / 6)) * beltsPrice + students * robesPrice;

			if (totalPrice <= money)
			{
				Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {(totalPrice - money):F2}lv more.");
			}
		}
	}
}
