using NUnit.Framework;
 
namespace Csharp_Coding_Test_Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorTest
    {
        [TestCase]
        public void test_1()
        {
            Assert.AreEqual(FibonacciCalculator.Calculate(0), 0);
        }

        [TestCase]
        public void test_2()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(5), 5);
        }

        [TestCase]
        public void test_3()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(20), 6765);
        }

        [TestCase]
        public void test_4()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(25), 75025);
        }
    }
}