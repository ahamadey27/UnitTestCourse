using Xunit;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Given1and2_Returns3()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var sum = calculator.Add(1, 2);

            //Assertion
            Assert.Equal(2, sum); //First argument is expected value and second is actual
        }

        [Fact]
        public void Add_GivenTwoDecimalValues_ReturnsTwoDecimalPlaces()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var sum = calculator.Add(1.5m, 1.2m)

        }
    }
}
