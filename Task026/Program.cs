/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int CountNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.Write("Число = ");
int number = int.Parse(Console.ReadLine());
int CountN = CountNumber(number);
Console.WriteLine(CountN);