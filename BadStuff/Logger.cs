using System;
static class Logger
{
    public static MyAwaitable WriteLineAsync(FormattableString @string)
    {
        //TODO: Abuse formattable string
        Console.WriteLine($"{@string}");

        return new MyAwaitable { EraseBob = @string.ToString().Contains("Bob") };
    }
}
