using NUnit.Framework;
 
namespace Csharp_Coding_Test_Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorHiddenTest
    {
        [TestCase]
        public void test_hidden_1()
        {
            Assert.AreEqual(FibonacciCalculator.Calculate(14), 377);
        }

        [TestCase]
        public void test_hidden_2()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(15), 610);
        }

        [TestCase]
        public void test_hidden_3()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(18), 2584);
        }

        [TestCase]
        public void test_hidden_4()
        {
             Assert.AreEqual(FibonacciCalculator.Calculate(19), 4181);
        }
    }
}