using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class DateHelper
    {
        public static int GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek dayToTest, int month, int year)
        {
            var numberOfDays = DateTime.DaysInMonth(year, month);
            DateTime workingDate = new DateTime(year, month, numberOfDays);
            for (int i = 1; i < 7; i++)
            {
                if (workingDate.DayOfWeek == dayToTest)
                {
                    return workingDate.Day;
                }

                workingDate = workingDate.AddDays(-1);
            }

            return workingDate.Day;
        }

        public static int GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek dayToTest, DateTime datetimeInMonth)
        {
            return GetDAteOfLastOccurenceOfDayInMonth(dayToTest, datetimeInMonth.Month, datetimeInMonth.Year);
        }
    }
}
