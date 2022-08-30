/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.*/

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

int[] FindIndexOfMinArray(int[,] arr)
{
    int[] IndexOfMinArr = new int[2];
    int RowMin = 0;
    int ColMin = 0;
    int minArr = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minArr)
            {
                minArr = arr[i, j];
                RowMin = i;
                ColMin = j;
            }
        }
        IndexOfMinArr[0] = RowMin;
        IndexOfMinArr[1] = ColMin;
    }
    return IndexOfMinArr;
}

int[,] CorrectArrayToMinimum(int[,] arr)
{
    int[,] CorrectArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int correctI = 0;
    int correctJ = 0;
    for (int i = 0; i < CorrectArr.GetLength(0); i++)
    {
        if (i >= FindIndexOfMinArray(arr)[0]) correctI= i+1;
        else correctI = i;
        for (int j = 0; j < CorrectArr.GetLength(1); j++)
        {
            if (j >= FindIndexOfMinArray(arr)[1]) correctJ = j+1;
            else correctJ = j;
            CorrectArr[i, j] = arr[correctI, correctJ];
        }
    }
    return CorrectArr;
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
Console.WriteLine();
Console.WriteLine($"Наименьший элемент массива расположен на пересечении {String.Join(", ", FindIndexOfMinArray(myArray))}");
myArray = CorrectArrayToMinimum(myArray);
Console.WriteLine();
PrintArray(myArray);
