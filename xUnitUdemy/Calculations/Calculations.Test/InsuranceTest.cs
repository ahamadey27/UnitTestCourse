using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class InsuranceTest
    {
        [Fact]
        public void DiscountPercentage_GivenAgeOlerThan18_DisscountBetween5And20()
        {
            //Arrange 
            var insurance = new Insurance();

            //Act
            var disscount = insurance.DiscountPercentage(70);

            //Assert
            Assert.InRange(disscount, 5, 20);
        }

        [Fact]
        public void DiscountPercentage_GivenAgeBelow25_DisscountIs5()
        {
            //Arrange 
            var insurance = new Insurance();

            //Act
            var disscount = insurance.DiscountPercentage(age:24);

            //Assert
            Assert.Equal(5, disscount);

        }

        //Test for dealing with exceptions by combing act and assert
        [Fact]
        public void DiscountPercentage_GivenAgeISBelow18_ThrowException()
        {
            //Arrange 
            var insurance = new Insurance();

            //Act and Assert
            Assert.Throws<InvalidDataException>(() => insurance.DiscountPercentage(age: 15));
        }

        [Fact]

        public void Customer_YearsLessThan5_ReturnsCustomer()
        {
            var customer = CustomerFactory.GetInstance(yearsWithCompany: 3, age: 20);

            Assert.IsType<Customer>(customer);

            //Disscount = 15%
        }


    }
}
