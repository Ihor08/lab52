using System;

public class Test
{
	abstract class Exhibition
	{

		public string nameExhibition;
		public string surnameAuthor;

	}

	class Day : Exhibition
	{

		public int number = 0;
		public string rem = "none";

		public Day()
		{
			number = 0;
			rem = "none";
		}

		public Day(int n, string r)
		{
			number = n;
			rem = r;
		}

	}

	static void sum(ref Day[] day2020)
	{

		int summa = 0;

		for (int i = 0; i < 5; i++)
		{

			summa = summa + day2020[i].number;

		}

		Console.WriteLine("Summa = " + summa);

	}

	static void dayMin(ref Day[] day2020)
	{

		int min = 0;

		for (int i = 0; i < 5; i++)
		{

			if (day2020[i].number < day2020[min].number)
			{
				min = i;
			}

		}

		Console.WriteLine("Day ( min ) = " + (min + 1));

	}

	static void find(ref Day[] day2020, string s)
	{


		for (int i = 0; i < 5; i++)
		{

			if (day2020[i].rem == s)
			{
				Console.WriteLine("Present: " + s);
			}

		}

	}


	public static void Main()
	{

		Day[] day2020 = new Day[5];

		for (int i = 0; i < 5; i++)
		{
			day2020[i] = new Day();
			day2020[i].number = 24 + i;
			day2020[i].rem = "hi" + i;
		}

		/*
		sum(ref day2020);
		dayMin(ref day2020);
		find(ref day2020, "hi2");
		*/
		string z = "";
		Console.WriteLine("Select punct menu:");
		Console.WriteLine("1. Find, press: f");
		Console.WriteLine("2. Found min, press: m");
		Console.WriteLine("3. Found sum, press: s");
		Console.WriteLine("4. Exit, press: x");

		z = Console.ReadLine();

		switch (z)
		{

			case "f":
				find(ref day2020, "hi2");
				break;
			case "m":
				dayMin(ref day2020);
				break;
			case "s":
				sum(ref day2020);
				break;
			case "x":
				Console.WriteLine("Exit");
				break;
			default:
				Console.WriteLine("Select carent punct menu!");
				break;
		}

	}
}