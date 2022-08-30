/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//для хранения и вывода результатов решила использовать новый массив
double[] AverageOfColumnArray(int[,] arr)
{
    double[] AverageArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sumCol = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumCol += arr[i, j];
        }
        AverageArr[j] = Math.Round(sumCol / arr.GetLength(0), 1);
    }
    return AverageArr;
}

Console.WriteLine("Задаем массив");
Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, 1, 10);
PrintArray(myArray);
Console.Write("Среднее арифметическое в каждом столбце массива ");
Console.WriteLine($"{String.Join("; ", AverageOfColumnArray(myArray))}.");