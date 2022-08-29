//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool SearchArrayIndex(int[,] arr, int IndexRow, int IndexCol)
{
    if ((0 <= IndexRow && IndexRow < arr.GetLength(0)) &&
        (0 <= IndexCol && IndexCol < arr.GetLength(1)))
        return true;
    else
        return false;
}

Console.WriteLine("Задаем массив");
Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, 1, 100);
PrintArray(myArray);

Console.WriteLine("Введите позицию элемента для поиска");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

if (SearchArrayIndex(myArray, m, n))
    Console.WriteLine(myArray[m, n]);
else
    Console.WriteLine("Такого элемента в массиве нет");