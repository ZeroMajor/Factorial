using System;
using System.Numerics;
using Factorial.Factory;
using System.Diagnostics;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This software calculates factorial (n!) using three algorithms.");
			var factory = new CalculatorFactory();
			while (true)
			{
				CalculatorType calcType;
				bool inputCorrect;
				string str;
				
				while (true) 
				{
					Console.WriteLine("Please input the number of required algorithm: 1 - Simple, 2 - Fast, 3 - BinarySplit");
					str = Console.ReadLine();
					int val;
					inputCorrect = Int32.TryParse(str, out val) && Enum.IsDefined(typeof(CalculatorType), val);
					if (inputCorrect)
					{
						calcType = (CalculatorType)val;
						break;
					}
					else
					{
						Console.WriteLine("Number incorrect, please try again");
					}
				}

				int n;

				while (true)
				{
					Console.WriteLine("Please input the integer which you need factorial for:");
					str = Console.ReadLine();
					inputCorrect = Int32.TryParse(str, out n);
					if (inputCorrect)
					{
						break;
					}
					else
					{
						Console.WriteLine("Number incorrect, please try again");
					}
				}

				var calculator = factory.GetFactorialCalculator(calcType);
				try
				{
					Console.WriteLine("{0}!  = {1}", n, calculator.Factorial(n));
				}
				catch (ArgumentOutOfRangeException aorEx)
				{
					Console.WriteLine("Error occured: {0}", aorEx.Message);
				}
				catch (Exception ex)
				{
					Console.WriteLine("General error occured: {0}", ex.Message);
				}
			}

		}
	}
}
