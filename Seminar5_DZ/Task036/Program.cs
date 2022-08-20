/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int SumOfIndex(int[] arr)
{
    int sumIndex = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sumIndex += arr[i];
    return sumIndex;
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона элементов массива: ");
int beginNumber = int.Parse(Console.ReadLine());
Console.Write("Введите окончание диапазона элементов массива: ");
int endNumber = int.Parse(Console.ReadLine());

int[] array = SetArray(count, beginNumber, endNumber);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + SumOfIndex(array));
