using System;
using System.Numerics;
using Factorial.Interface;

/// <summary>
/// Provides implementations of factorial calculators
/// </summary>
namespace Factorial.Calculators
{
	/// <summary>
	/// Provides faster calculation method
	/// <para>Idea is that multiplying two big numbers with relatively same size is more effective than straight calc</para>
	/// </summary>
	class FastCalculator : IFactorialCalculator
	{
		/// <summary>
		/// Use tree-like calculation to group the same-size numbers (divide-and-conquer)
		/// </summary>
		/// <param name="from">From value</param>
		/// <param name="thru">Thru value</param>
		/// <returns>Result of calculation</returns>
		private BigInteger TreeCalc(int from, int thru)
		{
			if (from > thru)
				return 1;
			if (from == thru)
				return from;
			if (thru - from == 1)
				return (BigInteger)from * thru;

			int mid = (from + thru) / 2;

			return TreeCalc(from, mid) * TreeCalc(mid + 1, thru);
		}

		public BigInteger Factorial(int n)
		{
			if (n < 0)
				throw new ArgumentOutOfRangeException("Factorial base should be non-negative");

			if (n == 0)
				return 1;

			if (n == 1 
				|| n == 2)
				return n;

			return TreeCalc(2, n);
		}
	}
}
