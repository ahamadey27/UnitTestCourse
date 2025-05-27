using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;
using RoomBookingApp.Core.Models;       // This using is correct
using RoomBookingApp.Core.Processors;   // This using is correct

// Recommended namespace for the test file
namespace RoomBookingApp.Core.Tests 
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Request_With_Request_Values()
        {
            //Arrange
            var request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2025, 10, 20)
            };
            var processor = new RoomBookingRequestProcessor();


            //Act
            RoomBookingResult result = processor.BookRoom(request);

            //Assert
            Assert.NotNull(result);
            result.ShouldNotBeNull();
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

            //Assert - alternative test using Shouldly NuGet Package
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }

        [Fact]
        public void Should_Return_Room_Booking_Request()
        {
            var bookingRequest = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2025, 10, 20)
            };

            var processor = new RoomBookingRequestProcessor();

            processor.BookRoom(bookingRequest); 
        }
    }
}