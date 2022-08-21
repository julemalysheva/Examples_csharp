/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}
//здесь я создавала функцию, которая просто проверяла вхождение в диапазон значений
int CountIndexArr(int[] arr, int firstNum, int secondNum)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= firstNum && arr[i] <= secondNum)
        {
            count++;
        }
    }
    return count;
}
//однако по условию нам явно нужно найти двузначные числа, поэтому можно искать так:
int SearchTwoDigit(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if ((el / 10 >= 1) && (el / 10 < 10))
        {
            count++;
        }
    }
    return count;
}

int[] array = SetArray(123, 0, 1000);
Console.WriteLine();
Console.WriteLine("количество элементов в отрезке [10,99]: " + CountIndexArr(array, 10, 99));
Console.WriteLine("количество двузначных чисел: " + SearchTwoDigit(array));
