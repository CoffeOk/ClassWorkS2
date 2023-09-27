// Ввод - число
// Вывод - кратно ли оно одновременно 7 и 23


int n;

bool Multiple (int a)
{
    return a % 7 == 0 && a % 23 == 0;
}

Console.Write("Введите число n: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.WriteLine("Введите число n: ");
/* 
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine($"{n} -> yes");
else
    Console.WriteLine($"{n} -> no"); 
*/

bool result = Multiple (n);
Console.WriteLine (result ? $"{n} -> yes" : $"{n} -> no" );