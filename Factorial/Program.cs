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
			var factory = new CalculatorFactory();
			var calc1 = factory.GetFactorialCalculator(CalculatorType.Simple);
			var calc2 = factory.GetFactorialCalculator(CalculatorType.Fast);

			// warming
			for (int i = 0; i < 10000; i++)
			{
				for (uint n = 20; n < 50; n++)
				{
					var val1 = calc1.Factorial(n);
					var val2 = calc2.Factorial(n);
				}
			}

			var sw1 = Stopwatch.StartNew();
			for (int i = 0; i < 20000; i++)
			{
				var val = calc1.Factorial(500);
			}
			sw1.Stop();

			var sw2 = Stopwatch.StartNew();
			for (int i = 0; i < 20000; i++)
			{
				var val = calc2.Factorial(500);
			}
			sw2.Stop();

			Console.WriteLine("Simple: {0} ms{1}Fast: {2} ms", sw1.ElapsedMilliseconds, Environment.NewLine, sw2.ElapsedMilliseconds);
		}
	}
}
