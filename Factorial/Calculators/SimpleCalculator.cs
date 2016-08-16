using System;
using System.Numerics;
using Factorial.Interface;

/// <summary>
/// Provides implementations of factorial calculators
/// </summary>
namespace Factorial.Calculators
{
	/// <summary>
	/// Provides simple calculation method
	/// </summary>
	public class SimpleCalculator : IFactorialCalculator
	{
		public BigInteger Factorial(int n)
		{
			if (n < 0)
				throw new ArgumentOutOfRangeException("Factorial base should be non-negative");

			if (n == 0)
				return 1;
			if (n == 1
				|| n == 2)
				return n;

			BigInteger result = 2;
			for (int i = 3; i <= n; i++)
				result *= i;

			return result;
		}
	}
}
