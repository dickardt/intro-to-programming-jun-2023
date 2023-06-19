
namespace BusinessClock.IntegrationTests
{
    public class DemoTests
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            //Given
            int a = 10, b = 20, answer;
            //When
            answer = a + b;
            //Then
            Assert.Equal(30, answer);
        }
        [Theory]
        [InlineData(10,20,30)]
        [InlineData(20, 20, 40)]
        [InlineData(65, 20, 85)]
        public void CanAddAnyTwoNumbers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
