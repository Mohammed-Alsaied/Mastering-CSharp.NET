using System;

namespace _028__Extension_Methods
{
    public class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWeekDay(DateTime value)
        {
            return !IsWeekEnd(value);
        }

    }
}
