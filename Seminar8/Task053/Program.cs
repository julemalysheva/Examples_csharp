/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
и последнюю строку массива.*/

int[,] GetArray(int row, int col, int beginNum, int endNum)
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

void PrintArray(int[,] arr)
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

int[,] ReplaceFirstEndRowArray(int[,] arr)
{
    int row = arr.GetLength(0) - 1;
    //смотрим только первую строку, поэтому цикл один
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        (arr[0, j], arr[row, j]) = (arr[row, j], arr[0, j]);
    }
    return arr;
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
myArray = ReplaceFirstEndRowArray(myArray);
Console.WriteLine();
PrintArray(myArray);