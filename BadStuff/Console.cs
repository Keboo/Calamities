using System;
static class Console
{
    public static MyAwaitable WriteLineAsync(FormattableString @string)
    {
        //TODO: Abuse formattable string
        System.Console.WriteLine($"{@string}");

        return new MyAwaitable { EraseBob = @string.ToString().Contains("Bob") };
    }

    public static string ReadLine() => System.Console.ReadLine();
}
