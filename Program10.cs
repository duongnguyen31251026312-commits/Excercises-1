int totalDays = int.Parse(Console.ReadLine());

int years = totalDays / 365;
int weeks = (totalDays % 365) / 7;
int days = (totalDays % 365) % 7;

Console.WriteLine($"{totalDays} ngay tuong duong voi:");
Console.WriteLine($"{years} nam, {weeks} tuan va {days} ngay.");
