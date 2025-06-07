using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenFirstLastName_ReturnsFullName()
        {
            //Arrange
            var names = new Names();

            //Act
            var fullName = names.MakeFullName("Alex", "Hamadey");

            //Assertion
            Assert.Equal("Alex Hamadey", fullName, ignoreCase: true);
        }

        [Fact]
        public void MakeFullName_GivenFirstLastName_FirstNameExists()
        {
            //Arrange
            var names = new Names();

            //Act
            var fullName = names.MakeFullName("Alex", "Hamadey");

            //Assertion
            Assert.Contains("Alex", fullName, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullName_GivenFirstLastName_BeginsWithFirstName()
        {
            //Arrange
            var names = new Names();

            //Act
            var fullName = names.MakeFullName("Alex", "Hamadey");

            //Assertion
            Assert.StartsWith("Alex", fullName, StringComparison.InvariantCultureIgnoreCase); //ignores case
        }

        [Fact]
        public void MakeFullName_GivenFirstLastName_MatchesRegex()
        {
            //Arrange
            var names = new Names();

            //Act
            var fullName = names.MakeFullName("Alex", "Hamadey");

            //Assertion
            Assert.Matches("[A-Z]{1}[a-z]+[A-Z]{1}[a-z]+$", fullName);
            // Regex pattern explanation:
            // ^             : Start of the string
            // [A-Z]{1}      : Matches exactly one uppercase letter (first letter)
            // [a-z]+        : Matches one or more lowercase letters
            // [A-Z]{1}      : Matches exactly one uppercase letter (second capital)
            // [a-z]+        : Matches one or more lowercase letters
            // $             : End of the string (ensures no extra characters)
        }
    }
}
