// На вход принимает два числа
// На выходе - кратно ли первое число второму
// Если нет - вывести остаток от деления

int a, b; 

int OstatokDelenia(int x, int y)
{
   int z = x % y;
   return z; 
} 

Console.Write("Введите число a: ");
while (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Введите число a: ");
Console.Write("Введите число b: ");
while (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Введите число b: ");
// int x = a % b;
int c = OstatokDelenia (a, b);
if (a % b == 0)
    Console.WriteLine($"{a}, {b} -> Кратно");
else
    Console.WriteLine($"{a}, {b} -> Не кратно, остаток {c}");