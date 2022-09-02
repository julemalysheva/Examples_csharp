/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Int64 PowRec(int a, int n)
{
    //return n == 0 ? 1 : a * PowRec(a, n - 1);
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowRec(a * a, n / 2);
    else return a * PowRec(a, n - 1);
}

Console.Write("Введите онование степени, А (не равное нулю): ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени, B: ");
int B = int.Parse(Console.ReadLine());
if (A == 0 || B < 0) //степень 0 оставляю
{
    Console.WriteLine("Введенные значения не соответствуют условию");
}
else
    Console.WriteLine(PowRec(A, B));


/* код итеративного решения:

int PowNumber(int x, int y)
{
    int result = 1;

    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}
*/
