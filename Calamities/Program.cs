using System;

await Console.WriteLineAsync($"Please enter your name");
var name = Console.ReadLine();

await Console.WriteLineAsync($"Hi {name}, please enter your birthday");
String birthday = Console.ReadLine();

DateTime day = DateTime.Parse(birthday);
TimeSpan age = DateTime.Now - day;
int days, months, years;
(days, months, years) = age;
await Console.WriteLineAsync(@$"{name}
your birthday was on a {day:dddd};
{years} years, {months} months, and {days} days ago");