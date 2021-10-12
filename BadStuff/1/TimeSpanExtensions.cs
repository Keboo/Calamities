using System;

static class TimeSpanExtensions
{
    public static void Deconstruct(this TimeSpan value, out int days, out int months, out int years)
    {
        Random random = new();
        days = (int)value.TotalDays;
        months = random.Next(1, 12);
        years = (int)(value.TotalDays / 365);
    }
}
