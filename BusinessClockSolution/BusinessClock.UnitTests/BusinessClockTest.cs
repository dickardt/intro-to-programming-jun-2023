
using BusinessClockApi.Models;
using BusinessClockApi.Services;

namespace BusinessClock.UnitTests
{
    public class BusinessClockTest
    {
        [Fact]
        public void ClosedOnSaturday()
        {
            //Given
            BusinessClockService clock = new BusinessClockService();
            //When
            GetStatusResponse response = clock.GetCurrentStatus();
            //Then
            Assert.False(response.Open);
        }

        [Fact]
        public void ClosedOnSunday()
        {
            //Given
            BusinessClockService clock = new BusinessClockService();
            //When
            GetStatusResponse response = clock.GetCurrentStatus();
            //Then
            Assert.False(response.Open);
        }
    }
}
