using System;
using System.Threading.Tasks;

namespace Calamities
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Logger.WriteLineAsync($"Please enter your name");
            var name = Console.ReadLine();
            await Logger.WriteLineAsync($"Hi {name}");

            await Logger.WriteLineAsync($"Please enter your birthday");
            String birthday = Console.ReadLine();

            if (DateTime.TryParse(birthday, out DateTime birthdateDateTime))
            {
                TimeSpan age = DateTime.Now - birthdateDateTime;
                int days, months, years;
                (days, months, years) = age;
                await Logger.WriteLineAsync($"{name} you are {years} years, {months} months, and {days} days old");
            }
        }
    }
}
