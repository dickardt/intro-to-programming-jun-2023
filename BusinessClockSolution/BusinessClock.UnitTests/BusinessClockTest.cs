﻿
using BusinessClockApi.Models;
using BusinessClockApi.Services;
using Moq;

namespace BusinessClock.UnitTests
{
    public class BusinessClockTest
    {
        [Fact]
        public void ClosedOnSaturday()
        {
            //Given
            var stubbedSaturdaySystemTime = new Mock<ISystemTime>();
            stubbedSaturdaySystemTime.Setup(c => c.getCurrent()).Returns(new DateTime(2023, 6, 17, 9, 5, 00));
            BusinessClockService clock = new BusinessClockService(stubbedSaturdaySystemTime.Object);
            //When
            GetStatusResponse response = clock.GetCurrentStatus();
            //Then
            Assert.False(response.Open);
        }

        [Fact]
        public void ClosedOnSunday()
        {
            //Given
            var stubbedSaturdaySystemTime = new Mock<ISystemTime>();
            stubbedSaturdaySystemTime.Setup(c => c.getCurrent()).Returns(new DateTime(2023, 6, 18, 9, 5, 00));
            BusinessClockService clock = new BusinessClockService(stubbedSaturdaySystemTime.Object);
            //When
            GetStatusResponse response = clock.GetCurrentStatus();
            //Then
            Assert.False(response.Open);
        }

        [Theory]
        [InlineData("6/19/2023 9:00:00 AM")]
        [InlineData("6/19/2023 4:59:00 PM")]

        public void OpenTimes(string dateTime)
        {
            var stubbedClock = new Mock<ISystemTime>();
            stubbedClock.Setup(c => c.getCurrent()).Returns(DateTime.Parse(dateTime));
            var clock = new BusinessClockService(stubbedClock.Object);

            GetStatusResponse response = clock.GetCurrentStatus();

            Assert.True(response.Open);
        }


        [Theory]
        [InlineData("6/19/2023 8:59:00 AM")]
        [InlineData("6/19/2023 5:00:00 PM")]

        public void ClosedTimes(string dateTime)
        {
            var stubbedClock = new Mock<ISystemTime>();
            stubbedClock.Setup(c => c.getCurrent()).Returns(DateTime.Parse(dateTime));
            var clock = new BusinessClockService(stubbedClock.Object);

            GetStatusResponse response = clock.GetCurrentStatus();

            Assert.False(response.Open);
        }
    }
}
