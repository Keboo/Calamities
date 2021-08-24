using System.Runtime.CompilerServices;
using System.Globalization;
using System.Threading;
using System;
using System.Linq;

class Init
{
    [ModuleInitializer]
    internal static void ModuleInitializer()
    {
        Random random = new();
        CultureInfo updated = (CultureInfo) CultureInfo.CurrentCulture.Clone();
        //updated.DateTimeFormat.ShortDatePattern = @"yyyy-MM-dd";
        //updated.DateTimeFormat.LongTimePattern = "";
        updated.NumberFormat.NegativeSign = "++";
        updated.NumberFormat.DigitSubstitution = DigitShapes.NativeNational;
        //updated.NumberFormat.CurrencyDecimalDigits = 1;
        string[] nativeDig = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        //for (int i = 0; i < 10; i++)
        //{
        //    if (CharUnicodeInfo.GetDecimalDigitValue(nativeDig[i], 0) != i &&
        //        CharUnicodeInfo.GetUnicodeCategory(nativeDig[i], 0) != UnicodeCategory.PrivateUse)
        //    {
        //    }
        //}

        updated.NumberFormat.NativeDigits = nativeDig;

        string[] shuffled = nativeDig
            .OrderBy(e => random.NextDouble())
            .ToArray();
        for(int i = 0; i < shuffled.Length; i++)
        {
            nativeDig[i] = shuffled[i];
        }

        Thread.CurrentThread.CurrentCulture = updated;
    }
}