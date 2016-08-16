using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Factorial.Interface;
using Factorial.Factory;

namespace FactorialTest
{
	[TestClass]
	public class SimpleFactorialUnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestNegativeSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			calc.Factorial(-1);
		}


		[TestMethod]
		public void TestZeroSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(1, calc.Factorial(0));
		}

		[TestMethod]
		public void TestOneSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(1, calc.Factorial(1));
		}

		[TestMethod]
		public void TestTwoSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(2, calc.Factorial(2));
		}

		[TestMethod]
		public void TestThreeSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(6, calc.Factorial(3));
		}

		[TestMethod]
		public void TestTenSimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(3628800, calc.Factorial(10));
		}

		[TestMethod]
		public void TestTwentySimple()
		{
			var factory = new CalculatorFactory();
			var calc = factory.GetFactorialCalculator(CalculatorType.Simple);
			Assert.AreEqual(2432902008176640000, calc.Factorial(20));
		}
	}
}
