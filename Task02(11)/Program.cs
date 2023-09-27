//Ввод: Рандом от 100 до 1000
//Вывод: Число с удалённым десятком


int num = new Random().Next(100, 1000);
int sot = num % 10;
int ed = num / 100;
Console.Write ($"{num} -> {ed}{sot}");  