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
                Console.WriteLine($"{name} you are {age.TotalDays} days old");
            }
            else
            {
                Console.Error.WriteLine("Failed to parse birthday");
            }
        }
    }
}
