using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTest
{
    public class CalculatorTest
    {
        [Fact] // This attribute marks the method as a test case that can be run by the xUnit test runner.
        public void Add_PositiveNumbers_RetursExpectedResults()
        {
            //Arrange: This section is where you set up the necessary preconditions and inputs for your test.
            var calculator = new Calculator(); // Create an instance of the class you want to test.
            int a = 3; // Define the first input value.
            int b = 5; // Define the second input value.

            int expectedResult = 8; // Define the expected outcome of the test.

            //Act: This section is where you execute the method or functionality that you want to test.
            int actualResult = calculator.Add(a, b); // Call the Add method on the calculator instance with the defined inputs.

            //Assert: This section is where you verify that the actual outcome matches the expected outcome.
            Assert.Equal(expectedResult, actualResult); // Use an assertion to check if the actual result is equal to the expected result.

            
        }
    }
}