using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace lastdayofmonth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("lastdayofmonth monday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Monday, date));
            Console.WriteLine("lastdayofmonth tuesday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Tuesday, date));
            Console.WriteLine("lastdayofmonth wednesday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Wednesday, date));
            Console.WriteLine("lastdayofmonth thursday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Thursday, date));
            Console.WriteLine("lastdayofmonth friday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Friday, date));
            Console.WriteLine("lastdayofmonth saturday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Saturday, date));
            Console.WriteLine("lastdayofmonth sunday of this month: " + DateHelper.GetDAteOfLastOccurenceOfDayInMonth(DayOfWeek.Sunday, date));

            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
