using Xunit;
using Calculations;

namespace Calculations.Test;

public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
        //Arrange : Prepatre for testing
        var calculator = new Calculator();

        //Act : Actual code to test
        var sum = calculator.Add(1, 2);


        //Assert : Results are evaluated
        Assert.Equal(2, sum); //Fist argument is expected value. Second is the actual value

    }

    [Fact]
    public void Add_GivenTwoDecimalValue_ReturnSumWithTwoPlaces()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var sum = calculator.Add(1.5m, 1.2m); //m signifies decimal value

        //Assertion
        Assert.Equal(2.7m, sum);
    }
}
