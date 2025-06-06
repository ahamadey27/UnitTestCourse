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
            Assert.Equal("Alex Hamadey", fullName);
        }
    }
}
