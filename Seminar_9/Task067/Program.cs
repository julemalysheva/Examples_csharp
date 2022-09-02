/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int SumNumber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNumber(num / 10);
    //if (num <= 0) return 0;
    //else return num % 10 + SumNumber(num / 10);
}

Console.Write("Число = ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumNumber(number));

/* код программы итеративный способ:
int SumNumber(int num)
{
    int SumNumber = 0;
    while (num > 0)
    {
        SumNumber = SumNumber + num % 10;
        num /= 10;
    }
    return SumNumber;
}*/