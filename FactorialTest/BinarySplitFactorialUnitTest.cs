using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Factorial.Interface;
using Factorial.Factory;

namespace FactorialTest
{
	[TestClass]
	public class BinarySplitFactorialUnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestNegativeBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			calc.Factorial(-1);
		}

		[TestMethod]
		public void TestZeroBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(1, calc.Factorial(0));
		}

		[TestMethod]
		public void TestOneBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(1, calc.Factorial(1));
		}

		[TestMethod]
		public void TestTwoBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(2, calc.Factorial(2));
		}

		[TestMethod]
		public void TestThreeBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(6, calc.Factorial(3));
		}

		[TestMethod]
		public void TestTenBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(3628800, calc.Factorial(10));
		}

		[TestMethod]
		public void TestTwentyBinarySplit()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.BinarySplit);
			Assert.AreEqual(2432902008176640000, calc.Factorial(20));
		}
	}
}
