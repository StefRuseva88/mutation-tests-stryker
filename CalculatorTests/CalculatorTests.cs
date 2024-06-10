using Calculator;


namespace CalculatorTests

{
    public class CalculatorTests
    {
        public CalculatorEngine calculatorEngine = new CalculatorEngine();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(5, 5, 10)]
        public void TestSumMethod(int first, int second, int expected)
        {
            var result = calculatorEngine.Sum(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 5, 0)]
        public void TestSubtractMethod(int first, int second, int expected)
        {
            var result = calculatorEngine.Subtract(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 5, 25)]
        public void TestMultiplyMethod(int first, int second, int expected)
        {
            var result = calculatorEngine.Multiply(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 5, 1)]
        public void TestDivideMethod(int first, int second, int expected)
        {
            var result = calculatorEngine.Divide(first, second);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 0)]
        public void TestDivideMethodByZero(int first, int second)
        {
            Assert.Throws<DivideByZeroException>(() => calculatorEngine.Divide(first, second));
        }
    }
}