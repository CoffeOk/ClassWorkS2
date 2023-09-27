//Ввод: Рандом от 10 до 99
//Вывод: Найбольшая цифра числа


//Решение 1.

int num = new Random().Next(10,100);
//Console.Write($"Случайное число -> {num}");
int a = num / 10;
int b = num % 10;
if (a > b)
{
    Console.WriteLine($"{num} -> {a}");
}
else
{
    Console.WriteLine($"{num} -> {b}");
}

//Ternarnii operator

int maxDigit = a > b ? a : b;
Console.WriteLine($"{num} -> {maxDigit}");