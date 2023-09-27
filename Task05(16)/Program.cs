// На вход два числа
// Является ли одно число квадратом другого


int a, b;
bool Square (int x, int y)
{
    return x * x == y || y * y == x; 
}
Console.Write("Введите число a: ");
while (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Введите число a: ");
Console.Write("Введите число b: ");
while (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Введите число b: ");
bool c = Square (a,b);
Console.WriteLine (c ? $"{a}, {b} -> да" : $"{c} -> no" );
/* 
if (a * a == b)
    Console.WriteLine($"{a}, {b} -> да");
else if (b * b == a)
    Console.WriteLine($"{a}, {b} -> да");
else 
    Console.WriteLine($"{a}, {b} -> нет"); 
*/