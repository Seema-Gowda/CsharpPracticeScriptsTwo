using System;

namespace RoundTwoIntermitent
{
	class Program
	{
		static void Main(string[] args)
		{
			MyMethodMathsStringFunc();
			MeathodLoopStatements();
			MeathodArrays();
		}

		static void MyMethodMathsStringFunc()
		{
		
				int x = 16, y = 8;
				string word = "\nSeema\nGowda", FirstName = "Namith", LastName = "Gowda";
				String FullName = String.Concat(FirstName, LastName);
				String Intrpolation = $"Interpollation concat Boss full name is : {FirstName} {LastName}";

				Console.WriteLine("---------------Math Functions------------------");
				Console.WriteLine(Math.Max(x, y));
				Console.WriteLine(Math.Sqrt(x));
				Console.WriteLine("67 hopsfrom" + x + " is " + (x += 67));

				Console.WriteLine("---------------String Functions------------------");
				Console.WriteLine("The lenght of txt string is  " + word.Length);
				Console.WriteLine("Remove words from 2nd char  " + word.Remove(2));
				Console.WriteLine("Full name is  " + word);
				Console.WriteLine("Replace S with K  " + word.Replace('S', 'K'));
				Console.WriteLine("ALL uPPER CASE  " + word.ToUpper());
				Console.WriteLine("Boss Full Name  " + FullName);
				Console.WriteLine(FullName);
				Console.WriteLine(word[0]);
				Console.WriteLine(word[6]);
				Console.WriteLine("To find Index of M is name " + word.IndexOf("m"));
				Console.WriteLine(x > y);
				Console.WriteLine(x <= y);
				Console.WriteLine(x == 16);
		    	Console.ReadLine();
		}

		static void MeathodLoopStatements()
		{
			Console.WriteLine("---------------If statements------------------");
			int a = 29, b = 67;
			Console.WriteLine("Enter value for a : " + a);
			//int a = Convert.ToInt16( Console.ReadLine());
			Console.WriteLine("Enter value for b : " + b);
			//int b = Convert.ToInt16(Console.ReadLine());

			if (a > b)
			{
				Console.WriteLine("a is the Greatest " + a);
			}
			else if (a == b)
			{
				Console.WriteLine("a is Equal to b " + a);
			}
			else
			{
				Console.WriteLine("b is the Greatest" + b);

			}

			int p = 85;
			if (p > 80)
				Console.WriteLine(p + " Is a Good score");
			else
				Console.WriteLine("Needs Improvement");
			//or another way
			String TernaryOprtr = (p > 80) ? p + " Ternary Op, Is a Good score" : "Ternary Op, Needs Improvement";
			Console.WriteLine(TernaryOprtr);

			Console.WriteLine("---------------Switch Case statements------------------");
			int Age = 35;
			switch (Age)
			{
				case 20:
					{
						Console.WriteLine("Good age for learning new things");
						break;
					}

				case 25:
					{
						Console.WriteLine("Good age for marriage");
						break;
					}
				case 35:
					{
						Console.WriteLine("Good age for kids");
						break;
					}
			}

			Console.WriteLine("---------------While statements------------------");
			int num = 2;
			Console.WriteLine("Even number listed below \n ");
			while (num < 100)
			{
				Console.WriteLine(num);
				num = num + 2;
			}

			Console.WriteLine("---------------For Loop statements------------------");
			Console.Write("Multiples of 5 \n ");
			for (int i = 0; i <= 100; i = i + 5)
			{
				Console.WriteLine(i);
			}

			string[] stingcol = { "Blue", "Yellow", "Pink", "Purple", "White", "Red" };

			int Len = stingcol.GetLength(0);
			Console.WriteLine(Len);

			for (int i = 0; i < Len; i++)
			{
				Console.WriteLine(stingcol[i]);
			}


			Console.WriteLine("---------------ForEach In Loop statements------------------");

			string[] week = { "Sunday", "Monday", "Tuesday", "Wed", "Thur", "Fri", "Saturday" };
			foreach (string i in week)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
		static void MeathodArrays()
		{
			Console.WriteLine("---------------ARRAYS Lenght/Sort------------------");

			string[] Dresses = { "Skirts", "Jeans", "Saree", "Bikini" };
			int types = Dresses.Length;
			Console.WriteLine("Total Variety of Indian dresses are : " + types);

			foreach (string display in Dresses)
			{
				Console.Write(" . " + display);
			}

			int[] OrdeNum = { 123, 23, 11, 5454, 989 };
			string[] OrdWord = { "Suman", "Seema", "Shilpa", "Leela", "Rashmi", "Kavya", "Ramya" };
			Array.Sort(OrdeNum);
			Array.Sort(OrdWord);
			foreach (int i in OrdeNum)
			{
				Console.WriteLine(i);
			}
			foreach (string kil in OrdWord)
			{
				Console.WriteLine(kil);
			}

			Console.ReadLine();
		}
	}
}
