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
            Assert.Equal(3, sum); // Corrected expected value from 2 to 3
        }

        [Fact]
        public void Add_GivenTwoDecimalValues_ReturnsTwoDecimalPlaces()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            
            var sum = calculator.Add(1.5m, 1.2m); 

            //Assert
            // Ensure the expected value has the 'm' suffix to denote it as a decimal
            Assert.Equal(2.7m, sum); // This assertion expects 'sum' to be a decimal
        }
    }
}
