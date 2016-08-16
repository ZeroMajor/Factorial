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
		Simple = 1,
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
		private SimpleCalculator simpleCalculator;
		private FastCalculator fastCalculator;
		private BinarySplitCalculator binarySplitCalculator;

		/// <summary>
		/// Returns instance of Factorial Calculator of selected type
		/// </summary>
		/// <param name="calcType">Type of Factorial Calculator</param>
		/// <returns>Instance of Factorial Calculator</returns>
		public IFactorialCalculator GetFactorialCalculator(CalculatorType calcType)
		{
			switch(calcType)
			{
				case CalculatorType.Simple:
					if (simpleCalculator == null)
						simpleCalculator = new SimpleCalculator();
					return simpleCalculator;

				case CalculatorType.Fast:
					if (fastCalculator == null)
						fastCalculator = new FastCalculator();
					return fastCalculator;

				case CalculatorType.BinarySplit:
					if (binarySplitCalculator == null)
						binarySplitCalculator = new BinarySplitCalculator();
					return binarySplitCalculator;

				default:
					throw new NotImplementedException("Such factorial calculation is not defined");
			}
		}
	}
}
