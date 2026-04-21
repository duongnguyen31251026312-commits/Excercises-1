Console.Write("Nhap mot ky tu: ");
char character = Console.ReadKey().KeyChar;
Console.WriteLine();
int asciiValue = (int)character;
Console.WriteLine($"Ma ASCII cua '{character}' la: {asciiValue}");
