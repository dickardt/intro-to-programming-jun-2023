using BusinessClockApi.Models;

namespace BusinessClockApi.Services
{
    public class BusinessClockService
    {
        public GetStatusResponse GetCurrentStatus()
        {
            bool isOpen = DateTime.Now.DayOfWeek != DayOfWeek.Sunday || DateTime.Now.DayOfWeek != DayOfWeek.Saturday;
            return new GetStatusResponse { Open = isOpen };
        }
    }
}
