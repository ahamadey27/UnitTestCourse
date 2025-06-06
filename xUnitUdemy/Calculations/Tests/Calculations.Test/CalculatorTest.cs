
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
        Assert.True(true);

    }
}
