using NUnit.Framework;
 
namespace CodeScreen.Assessments.Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorHiddenTest
    {
        [TestCase]
        public void TestHidden1()
        {
            Assert.AreEqual(FibonacciCalculator.Calculate(14), 377);
        }

        [TestCase]
        public void TestHidden2()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(15), 610);
        }

        [TestCase]
        public void TestHidden3()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(18), 2584);
        }

        [TestCase]
        public void TestHidden4()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(19), 4181);
        }
    }
}