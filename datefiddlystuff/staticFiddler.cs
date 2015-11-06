using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datefiddlystuff
{
    public static class staticFiddler
    {
        public static int GetLastDayOfMonth(DayOfWeek day, int month, int year)
        {
            var numberOfDays = DateTime.DaysInMonth(year, month);
            DateTime workingDate = new DateTime(year, month, numberOfDays);
            for (int i = 1; i < 7; i++)
            {
                if (workingDate.DayOfWeek == day)
                {
                    return workingDate.Day;
                }

                workingDate = workingDate.AddDays(-1);
            }

            return workingDate.Day;
        }
    }
}
