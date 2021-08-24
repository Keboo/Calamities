using System;

await Console.WriteLineAsync($"Please enter your name");
var name = Console.ReadLine();

await Console.WriteLineAsync($"Hi {name}, please enter your birthday");
String birthday = Console.ReadLine();

TimeSpan age = DateTime.Now - DateTime.Parse(birthday);
int days, months, years;
(days, months, years) = age;
await Console.WriteLineAsync($"{name} you are {years} years, {months} months, and {days} days old");
