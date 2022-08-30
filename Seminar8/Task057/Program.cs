/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.*/

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

int[] ChangeTypeArray(int[,] arr)
{
    int[] newArr = new int[arr.Length];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[index] = arr[i, j];
            index++;
        }
    }
    return newArr;
}

void BubbleSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }
    //return arr;
}

void DictionaryOfArrayElements(int[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] == arr[i + 1]) count++;
        else
        {
            Console.WriteLine($"Элемент {arr[i]} встречается {count} р.");
            count = 1;
        }

    }
    Console.WriteLine($"Элемент {arr[arr.Length-1]} встречается {count} р.");
}

Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(row, col, 1, 10);
PrintArray(myArray);
int[] newArr = ChangeTypeArray(myArray);
BubbleSort(newArr);
Console.WriteLine(String.Join(", ", newArr));
DictionaryOfArrayElements(newArr);
