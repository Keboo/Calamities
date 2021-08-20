using System;

await Logger.WriteLineAsync($"Please enter your name");
var name = Console.ReadLine();
await Logger.WriteLineAsync($"Hi {name}");

await Logger.WriteLineAsync($"Please enter your birthday");
String birthday = Console.ReadLine();

TimeSpan age = DateTime.Now - DateTime.Parse(birthday);
int days, months, years;
(days, months, years) = age;
await Logger.WriteLineAsync($"{name} you are {years} years, {months} months, and {days} days old");
