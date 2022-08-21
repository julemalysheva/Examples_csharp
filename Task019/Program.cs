/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());

if (num / 10000 > 0 && num / 10000 < 10)
{
    if (num / 10000 == num % 10 &&
     num / 1000 % 10 == num % 100 / 10)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("Число не пятизначное");
