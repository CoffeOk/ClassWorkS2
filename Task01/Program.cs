//Ввод: Рандом от 10 до 99
//Вывод: Найбольшая цифра числа


//Решение 1.

int num = new Random().Next(10,100);
//Console.Write($"Случайное число -> {num}");
int a = num / 10;
int b = num % 10;
if (a > b)
{
    Console.Write($"{num} - > {a}");
}
else
{
    Console.Write($"{num} - > {b}");
}
