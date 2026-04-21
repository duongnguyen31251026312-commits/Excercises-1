Console.Write("Nhap ban kinh hinh tron: ");
double r = Convert.ToDouble(Console.ReadLine());
double areaCircle = Math.PI * Math.Pow(r, 2);
Console.WriteLine($"Dien tich hinh tron la: {areaCircle:F2}");
