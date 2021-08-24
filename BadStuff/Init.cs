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
        CultureInfo updated = (CultureInfo) CultureInfo.CurrentCulture.Clone();
        //Because latin is cool
        updated.DateTimeFormat.DayNames = new[]
        {
            "Solis",
            "Lunae",
            "Martis",
            "Mercurii",
            "Jovis",
            "Veneris",
            "Saturni"
        };
        updated.NumberFormat.NegativeSign = "|_|> ";
        Thread.CurrentThread.CurrentCulture = updated;
    }
}