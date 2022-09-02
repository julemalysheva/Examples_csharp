/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

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
//функция находит произведение строки и столбца по полученным на вход индексам
int MultiplyRowByColumnByIndex(int[,] firstArr, int[,] secondArr, int indexRowFirst, int indexColSecond)
{
    int resultRowByCol = 0;
    for (int i = 0; i < firstArr.GetLength(1); i++)
        resultRowByCol += firstArr[indexRowFirst, i] * secondArr[i, indexColSecond];
    return resultRowByCol;
}

int[,] MatrixMultiplication(int[,] firstArr, int[,] secondArr)
{
    int[,] resultArray = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            resultArray[i, j] = MultiplyRowByColumnByIndex(firstArr, secondArr, i, j);
        }
    }
    return resultArray;
}

int[,] firstArray = GetArray(2, 3, 1, 10);
int[,] secondArray = GetArray(3, 2, 1, 10);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);

if (firstArray.GetLength(1) == secondArray.GetLength(0))
{
    Console.WriteLine("Произведение двух матриц: ");
    PrintArray(MatrixMultiplication(firstArray, secondArray));
}
else
    Console.WriteLine("Матрицы не согласованы");