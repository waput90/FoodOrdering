using System;

namespace FoodOrdering.Commons.Extensions
{
    public static class DateExtension
    {
        public static DateTime GetDate(this DateTime date) => date.Kind == DateTimeKind.Utc ? date : DateTime.UtcNow;
    }
}