/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int RowNumberOfArrayWithMinimumAmount(int[,] arr)
{
    int RowNumber = 0;
    int MinimumAmount = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        MinimumAmount += arr[0, k];
    }
    Console.WriteLine($"Сумма 0 индекса строк = {MinimumAmount}");//справочно вывожу для наглядности
    int SumCurrentRow = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        SumCurrentRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            SumCurrentRow += arr[i, j];
        }
        Console.WriteLine($"Сумма {i} индекса строк = {SumCurrentRow}");//справочно вывожу для наглядности
        if (SumCurrentRow < MinimumAmount)
        {
            MinimumAmount = SumCurrentRow;
            RowNumber = i;
        }
    }
    return RowNumber + 1; //по условию выводим не индекс, а наглядный номер
}

Console.WriteLine("Задаем массив");
Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, 1, 10);
PrintArray(myArray);
int NumberMinRow = RowNumberOfArrayWithMinimumAmount(myArray);
Console.WriteLine();
Console.WriteLine($"С наименьшей суммой элементов: {NumberMinRow} строка");