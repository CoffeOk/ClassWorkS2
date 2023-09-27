// На вход принимает два числа
// На выходе - кратно ли первое число второму
// Если нет - вывести остаток от деления

int a, b;
Console.Write("Введите число a: ");
while (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Введите число a: ");
Console.Write("Введите число b: ");
while (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Введите число b: ");
int x = a % b;
if (a % b == 0)
    Console.WriteLine($"{a}, {b} -> Кратно");
else
    Console.WriteLine($"{a}, {b} -> Не кратно, остаток {x}");