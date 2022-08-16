/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetF(num));

int GetF(int num)
{
    int F = 1;
    for(int i=2; i <= num; i++)
    {
        F *= i;
    }
    return F;
}