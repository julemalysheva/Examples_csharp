/*Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/

int[] GetCopy(int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i=0; i<arr.Length;i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int[] GetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int[] myArr = GetArray(10, 1, 20);//задаем массив произвольно
Console.WriteLine($"Задан массив: [{String.Join(", ", myArr)}]");
//GetCopy(myArr);
Console.WriteLine($"Копия массива: [{String.Join(", ", GetCopy(myArr))}]");