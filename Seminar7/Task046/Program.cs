/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

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