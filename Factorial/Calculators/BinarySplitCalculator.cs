using System;
using System.Numerics;
using Factorial.Interface;

/// <summary>
/// Provides implementations of factorial calculators
/// </summary>
namespace Factorial.Calculators
{
	/// <summary>
	/// Provides calculation method from Python's mathmodule
	/// <para>factorial(n) is written in the form 2^k * m, with m odd. k and m are computed separately, and then combined using a left shift.</para>
	/// </summary>
	class BinarySplitCalculator : IFactorialCalculator
	{
		/// <summary>
		/// Number of 1's in binary representation of number
		/// </summary>
		/// <param name="number">Integer value where we need to count number of 1's</param>
		/// <returns>Number of 1's</returns>
		private int Bit1Count(int number)
		{
			long w = (long)number;
			w -= (0xaaaaaaaa & w) >> 1;
			w = (w & 0x33333333) + ((w >> 2) & 0x33333333);
			w = w + (w >> 4) & 0x0f0f0f0f;
			w += w >> 8;
			w += w >> 16;

			return (int)(w & 0xff);
		}

		/// <summary>
		/// Returns the number of bits necessary to represent an integer in binary
		/// </summary>
		/// <param name="number">Integer value to be counted</param>
		/// <returns>Number of bits</returns>
		private int BitLength(int number)
		{
			int count = 0;
			while (number > 0)
			{
				count++;
				number = number >> 1;
			}
			return count;
		}

		private BigInteger currentN;

		private BigInteger Product(BigInteger start, BigInteger stop)
		{
			BigInteger numfactors = (stop - start) >> 1;
			if (numfactors == 2)
				return start * (start + 2);
			if (numfactors > 1)
			{
				BigInteger mid = (start + numfactors) | 1;
				return Product(start, mid) * Product(mid, stop);
			}

			if (numfactors == 1)
				return start;
			return 1;
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

			BigInteger inner = 1;
			BigInteger outer = 1;

			for (int i = BitLength(n); i > -1; i--)
			{
				inner *= Product((n >> i + 1) + 1 | 1, (n >> i) + 1 | 1);
				outer *= inner;
			}

			return outer << (n - Bit1Count(n));		
		}
	}
}
