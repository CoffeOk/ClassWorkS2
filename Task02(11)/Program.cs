//Ввод: Рандом от 100 до 1000
//Вывод: Число с удалённым десятком

using System.Runtime.InteropServices.ComTypes;

int num = new Random().Next(100, 1000);

int DeleteDes (int numb)
{
    int sot = numb % 10;
    int ed = numb / 100;
    return (ed * 10 +sot);
}

int res = DeleteDes (num);
Console.Write ($"{num} -> {res}");
/* 
int sot = num % 10;
int ed = num / 100;
Console.Write ($"{num} -> {ed}{sot}");   
*/