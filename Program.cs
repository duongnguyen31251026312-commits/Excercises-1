int x = 5, y = 10;
Console.WriteLine($"truoc khi hoan doi: x = {x}, y = {y}");
int temp = x;
x = y;
y = temp;
Console.WriteLine($"Sau khi hoan doi: x = {x}, y = {y}");
