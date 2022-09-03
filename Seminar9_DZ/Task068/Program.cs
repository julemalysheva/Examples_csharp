﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int AckF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckF(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckF(m - 1, AckF(m, n - 1));
    }
    else
        return n + 1;
}

Console.Write("M = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numberN = int.Parse(Console.ReadLine());
if (numberM >= 0 && numberN >= 0)
    Console.WriteLine(AckF(numberM, numberN));
else Console.WriteLine("Введите неотрицательные числа");