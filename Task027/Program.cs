/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int SumNumber(int num)
{
    int SumNumber = 0;
    while (num > 0)
    {
        SumNumber = SumNumber + num % 10;
        num /= 10;
    }
    return SumNumber;
}

//дальше я пробую вариант рекурсии, попалось на глаза нечто подобное, решила протестировать)
int SumNumberTwo(int num)
{
    if (num <= 0)
    {
        return 0;
    }
    return num % 10 + SumNumberTwo(num / 10);
}

Console.Write("Число = ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumNumber(number));
Console.WriteLine("Рекурсивная функция, Сумма цифр: " + SumNumberTwo(number));