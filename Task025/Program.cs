/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите онование степени, А (не равное нулю): ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени, B: ");
int B = int.Parse(Console.ReadLine());
if (A == 0 || B <= 0)
{
    Console.WriteLine("Введенные значения не соответствуют условию");
}
else
    Console.WriteLine(Degree(A, B));

int Degree(int x, int y)
{
    int result = 1;

    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}
