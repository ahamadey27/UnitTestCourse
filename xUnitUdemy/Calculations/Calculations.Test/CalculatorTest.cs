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

        [Fact]
        public void GetFibonacci_DoesNotInclude0()
        {
            var calculator = new Calculator();

            var fibo = calculator.GetFibonacci(length:5);

            Assert.All(fibo, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void GetFibonacci_DoesNotInclude4()
        {
            var calculator = new Calculator();

            var fibo = calculator.GetFibonacci(length: 5);

            Assert.DoesNotContain(4, fibo);
        }

        [Fact]
        public void GetFibonacci_DoesInclude5()
        {
            var calculator = new Calculator();

            var fibo = calculator.GetFibonacci(length: 5);

            Assert.Contains(5, fibo);
        }

        [Fact]
        public void GetFibonacci_First5ElementsAreCorrect()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var fibo = calculator.GetFibonacci(length: 5);
            var expectedSeries = new List<int>() { 1, 1, 2, 3, 5 };

            //Assertion
            Assert.Equal(expectedSeries, fibo);
        }
    }
}
