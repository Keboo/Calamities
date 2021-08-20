using System;

namespace Calamities
{
    static class TimeSpanExtensions
    {
        public static void Deconstruct(this TimeSpan value, out int days, out int months, out int years)
        {
            //TODO: What should these be?
            days = 42;
            months = 2;
            years = 35;
        }
    }
}
