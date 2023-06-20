using BusinessClockApi.Models;
using System.Globalization;
using System.Linq.Expressions;

namespace BusinessClockApi.Services
{
    public class BusinessClockService
    {
        private readonly ISystemTime _systemTime;

        public BusinessClockService(ISystemTime systemTime)
        {
            _systemTime = systemTime;
        }
        public GetStatusResponse GetCurrentStatus()
        {
            DateTime now = _systemTime.getCurrent();
            var dayOfTheWeek = now.DayOfWeek;
            var hour = now.Hour;

            var openingTime = new TimeSpan(9, 0, 0);
            var closingTime = new TimeSpan(17, 0, 0);

            var isOpen = dayOfTheWeek switch
            {
                DayOfWeek.Saturday => false,
                DayOfWeek.Sunday => false,
                _ => hour >= openingTime.Hours && hour < closingTime.Hours,
            };

            return new GetStatusResponse { Open = isOpen };
        }
    }
}

public interface ISystemTime
{
    DateTime getCurrent();
}

public class SystemTime : ISystemTime
{
    public DateTime getCurrent()
    {
        return DateTime.Now;
    }
}

