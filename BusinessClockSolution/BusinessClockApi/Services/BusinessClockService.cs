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
            bool isOpen = now.DayOfWeek != DayOfWeek.Sunday && now.DayOfWeek != DayOfWeek.Saturday;
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

