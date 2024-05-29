﻿namespace Fina.Core.Common
{
    public static class DateTimeExtension
    {
        public static DateTime GetFirstDate(this DateTime date, int? year = null, int? month = null)
            => new(year ?? date.Year, month ?? date.Month, 1);

        public static DateTime GetLastDate(this DateTime date, int? year = null, int? month = null)
            => new DateTime(
                year ?? date.Year,
                month ?? date.Month,
                1)
            .AddMonths(1)
            .AddDays(-1);
    }
}
