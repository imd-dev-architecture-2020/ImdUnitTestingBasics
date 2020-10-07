using UnitTestExample.Business;
using Xunit;

namespace UnitTestExample.Tests
{
    public class TestAdd
    {
        [Fact]
        public void TestAdd_SimpleAdd()
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var calculated = calculator.Add(1, 2);
            
            // ASSERT
            Assert.Equal(3, calculated);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-2, 2, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)] // overflows
        public void TestAdd_SimpleAdd_Theory(int value1, int value2, int expected)
        {
            // ARRANGE
            var calculator = new Calculator();

            // ACT
            var result = calculator.Add(value1, value2);

            // ASSERT
            Assert.Equal(expected, result);
        }
    }
}
