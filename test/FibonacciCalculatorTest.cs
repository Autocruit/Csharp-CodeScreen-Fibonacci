using NUnit.Framework;
 
namespace CodeScreen.Assessments.Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorTest
    {
        [TestCase]
        public void Test1()
        {
            Assert.AreEqual(FibonacciCalculator.Calculate(0), 0);
        }

        [TestCase]
        public void Test2()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(5), 5);
        }

        [TestCase]
        public void Test3()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(20), 6765);
        }

        [TestCase]
        public void Test4()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(25), 75025);
        }
    }
}