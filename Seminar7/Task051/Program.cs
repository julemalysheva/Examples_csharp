/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
 (с индексами (0,0); (1;1) и т.д.*/

int[,] GetArray(int row, int col, int beginNum, int endNum) //задаем массив
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr) //выводим на экран
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumMainDiagonalArray(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //sum += i == j ? arr[i, j] : 0;//ушла от этой строки, т.к. нужно применять несколько операторов после условия
            if (i == j)
            {
                sum += arr[i, j];
                Console.Write($"{arr[i, j]} + ");
            }
        }
    }
    return sum;
}

Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());
Console.Write("Начало диапазона значений: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Окончание диапазона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.Write(" = " + SumMainDiagonalArray(myArray));
Console.WriteLine();

