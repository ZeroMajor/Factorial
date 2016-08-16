using System;
using Factorial.Interface;
using Factorial.Calculators;

namespace Factorial.Factory
{
	/// <summary>
	/// List of possible factorial calculators
	/// </summary>
	public enum CalculatorType
	{
		/// <summary>
		/// Simple implementation, suitable for small numbers
		/// </summary>
		Simple,
		/// <summary>
		/// Faster calculation, suitable for numbers > 50
		/// </summary>
		Fast,
		/// <summary>
		/// Divide-and-conquer factorial algorithm based on formula provided at http://www.luschny.de/math/factorial/binarysplitfact.html
		/// </summary>
		BinarySplit
	};

	/// <summary>
	/// Provides method to create the required factorial calculator implementation
	/// </summary>
	public class CalculatorFactory
	{		
		public IFactorialCalculator GetFactorialCalculator(CalculatorType calcType)
		{
			switch(calcType)
			{
				case CalculatorType.Simple:
					return new SimpleCalculator();
				case CalculatorType.Fast:
					return new FastCalculator();
				case CalculatorType.BinarySplit:
					return new BinarySplitCalculator();
				default:
					throw new NotImplementedException("Such factorial calculation is not defined");
			}
		}
	}
}
