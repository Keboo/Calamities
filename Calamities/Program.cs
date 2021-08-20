using System;

namespace Calamities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your birthday");
            String birthday = Console.ReadLine();

            if (DateTime.TryParse(birthday, out DateTime birthdateDateTime))
            {
                TimeSpan age = DateTime.Now - birthdateDateTime;
                int days, months, years;
                (days, months, years) = age;
                Console.WriteLine($"{name} you are {years} years, {months} months, and {days} days old");
            }
        }
    }
}
