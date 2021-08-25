using System;
static class Console
{
    public static Task WriteLineAsync(FormattableString @string)
    {
        if (@string.ArgumentCount > 1)
        {
            object[] arguments = @string.GetArguments();
            for(int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = arguments[i] switch
                {
                    string s => s,
                    int month when i == 3 => month - 12,
                    int _ when i == 4 => "(ô¿ô)",
                    int j => j,
                    object o => o
                };
            }
            System.Console.WriteLine(string.Format(@string.Format, arguments));
        }
        else
        {
            System.Console.WriteLine($"{@string}");
        }

        return Task.CompletedTask;
    }

    public static var ReadLine()
    {
        System.Console.ReadLine();
        return new();
    }
}
