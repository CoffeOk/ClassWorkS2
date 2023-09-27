//Ввод: Рандом от 10 до 99
//Вывод: Найбольшая цифра числа


//Решение 1.

int MaxDigit(int nu)
{
    int a = nu / 10;
    int b = nu % 10;
    // int maxDigit = a > b ? a : b;
    // return maxDigit;
    return a > b ? a : b;
}
 int num = new Random().Next(10,100);
//Console.Write($"Случайное число -> {num}");
/*
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
*/

//Reshenir cherez metod

int maxDigit1 = MaxDigit(num);
Console.WriteLine($"{num} -> {maxDigit1}");
int maxDigit2 = MaxDigit(12);
Console.WriteLine($"max -> {maxDigit2}");
int maxDigit3 = MaxDigit(13);
Console.WriteLine($"max -> {maxDigit3}");
int maxDigit4 = MaxDigit(77);
Console.WriteLine($"max -> {maxDigit4}");
int maxDigit5 = MaxDigit(56);
Console.WriteLine($"max -> {maxDigit5}");


