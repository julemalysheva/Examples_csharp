/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int EvenNumArr(int[] arr)
{
    int evenCount = 0;
    foreach (int num in arr)
    {
        evenCount += (num % 2 == 0) ? 1 : 0;
    }
    return evenCount;
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArr = SetArray(size, 100, 1000);//задаем массив трехзначных чисел
//Console.WriteLine("В массиве:" + String.Join(" ", myArr) + " количество четных чисел: " + EvenNumArr(myArr));
Console.WriteLine($"В массиве: [{String.Join(", ", myArr)}] количество четных чисел = {EvenNumArr(myArr)}");