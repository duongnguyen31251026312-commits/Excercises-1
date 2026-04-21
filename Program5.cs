Console.Write("Nhap do Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
Console.Write("Nhap do Fahrenheit: ");
double f = Convert.ToDouble(Console.ReadLine());
double c = (f - 32) * 5 / 9;
Console.WriteLine($"{f}°F = {c}°C");
