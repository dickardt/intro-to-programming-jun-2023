
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;
using Alba;
using BusinessClockApi.Models;

namespace BusinessClock.IntegrationTests.Status
{
    public class GettingTheStatus
    {
        [Fact]
        public async Task OpenHours()
        {
            var host = await AlbaHost.For<Program>();

            var response = await host.Scenario(api =>
            {
                api.Get.Url("/status");
                api.StatusCodeShouldBeOk();
            });
            Assert.NotNull(response);
            GetStatusResponse responseMessage = response.ReadAsJson<GetStatusResponse>();
            Assert.True(responseMessage.Open);
            Assert.Null(responseMessage.OpensAt);
        }
    }
}
