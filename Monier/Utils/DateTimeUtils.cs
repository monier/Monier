using System;

namespace Monier.Utils
{
    /// <summary>
    /// Provides methods to manipulate dates and times
    /// </summary>
    public static class DateTimeUtils
    {
        /// <summary>
        /// Gets first date of the day
        /// </summary>
        /// <param name="date">concerned date</param>
        public static DateTime GetFirstDateOfDay(this DateTime date)
        {
            DateTime value = date;

            value = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            return value;
        }
        /// <summary>
        /// Gets last date of the day
        /// </summary>
        /// <param name="date">concerned date</param>
        public static DateTime GetLastDateOfDay(this DateTime date)
        {
            DateTime value = date;

            value = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            return value;
        }
        /// <summary>
        /// Gets first date of the month
        /// </summary>
        /// <param name="date">concerned date</param>
        public static DateTime GetFirstDateOfMonth(this DateTime date)
        {
            DateTime value = date;

            value = new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            return value;
        }
        /// <summary>
        /// Gets last date of the month
        /// </summary>
        /// <param name="date">concerned date</param>
        public static DateTime GetLastDateOfMonth(this DateTime date)
        {
            DateTime value = date;

            value = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month), 23, 59, 59);
            return value;
        }
        /// <summary>
        /// Gets first date of the year
        /// </summary>
        /// <param name="year">concernced year</param>
        public static DateTime GetFirstDateOfYear(int year)
        {
            DateTime value = DateTime.Now;

            value = new DateTime(year, 1, 1, 0, 0, 0);
            return value;
        }
        /// <summary>
        /// Gets last date of the year
        /// </summary>
        /// <param name="year">concerned year</param>
        public static DateTime GetLastDateOfYear(int year)
        {
            DateTime value = DateTime.Now;

            value = new DateTime(year, 12, DateTime.DaysInMonth(year, 12), 23, 59, 59);
            return value;
        }
    }
}
