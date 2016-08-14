﻿using System.Numerics;

namespace Factorial.Interface
{
	/// <summary>
	/// Provides a method to calculate factorial
	/// </summary>
	public interface IFactorialCalculator
	{
		/// <summary>
		/// Calculate the factorial of non-negative integer n
		/// </summary>
		/// <param name="n">The base of factorial</param>
		/// <returns><see cref="BigInteger"/> value of calculated factorial</returns>
		BigInteger Factorial(uint n);
	}
}
