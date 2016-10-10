using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DaysBetweenDates
    {
        static int DaysBetween(int year, int month, int day, int year2, int month2, int day2)
        {
            var firstTotalDays = CountYearDays(year)
                               + CountMonthDays(year, month)
                               + day;

            var secondTotalDays = CountYearDays(year2)
                                + CountMonthDays(year2, month2)
                                + day2;

            return Math.Abs(secondTotalDays - firstTotalDays);
        }

        static int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        static int CountYearDays(int year)
        {
            var sumOfDays = 0;

            // Start at year 1 as a base (or any year suitably early)
            for (var i = 1; i < year; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    sumOfDays += DaysInMonth(i, j);
                }
            }

            return sumOfDays;
        }

        static int CountMonthDays(int year, int month)
        {
            var sumOfDays = 0;

            // count up to, but not including current month.
            for (var i = 1; i < month - 1; i++)
            {
                sumOfDays += DaysInMonth(year, i);
            }

            return sumOfDays;
        }
    }
}