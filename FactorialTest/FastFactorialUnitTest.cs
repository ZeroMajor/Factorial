using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Factorial.Interface;
using Factorial.Factory;

namespace FactorialTest
{
	[TestClass]
	public class FastFactorialUnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestNegativeFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			calc.Factorial(-1);
		}

		[TestMethod]
		public void TestZeroFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(1, calc.Factorial(0));
		}

		[TestMethod]
		public void TestOneFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(1, calc.Factorial(1));
		}

		[TestMethod]
		public void TestTwoFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(2, calc.Factorial(2));
		}

		[TestMethod]
		public void TestThreeFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(6, calc.Factorial(3));
		}

		[TestMethod]
		public void TestTenFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(3628800, calc.Factorial(10));
		}

		[TestMethod]
		public void TestTwentyFast()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Fast);
			Assert.AreEqual(2432902008176640000, calc.Factorial(20));
		}
	}
}
