using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        [TestCase(-10, 20, 10)]
        public void TestAddition(
            double a,
            double b,
            double expected)
        {
            double actual =
                calculator.Addition(a, b);

            Assert.That(
                actual,
                Is.EqualTo(expected));
        }
    }
}