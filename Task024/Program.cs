/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetSumNums(num));
//функцию можно писать как ниже, так и выше момента вывода

int GetSumNums(int num)
{
    int sum = 0;
    for(int i=1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}