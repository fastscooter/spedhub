using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedHub.Domain.Helpers
{
    public static class SchoolDaysRemainingHelper
    {

        public static int GetDaysRemaining(DateOnly? endDate)
        {
            var start = DateOnly.FromDateTime(DateTime.Today);
            var end = endDate ?? DateOnly.MaxValue;
            var weekendDays = GetWeekendDays(start, end);
            var totalDays = (end.DayOfYear - start.DayOfYear) + 1;
            return totalDays - weekendDays;
        }
        public static int GetWeekendDays(DateOnly start, DateOnly end)
        {
            // Ensure start date is before end date
            if(start > end)
            {
                DateOnly temp = start;
                start = end;
                end = temp;
            }

            // Calculate total days between dates (inclusive of the start date)
            int totalDays = (end.DayOfYear - start.DayOfYear) + 1;

            // Find the day of the week for the start date (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
            int startDayOfWeek = (int)start.DayOfWeek;

            // Calculate full weeks and the remaining leftover days
            int fullWeeks = totalDays / 7;
            int leftoverDays = totalDays % 7;

            // Every full week has exactly 2 weekend days
            int weekendDays = fullWeeks * 2;

            // Evaluate the leftover days to see if they fall on a weekend
            for(int i = 0; i < leftoverDays; i++)
            {
                int currentDay = (startDayOfWeek + i) % 7;
                if(currentDay == 0 || currentDay == 6) // 0 is Sunday, 6 is Saturday
                {
                    weekendDays++;
                }
            }

            return weekendDays;
        }
    }
}
