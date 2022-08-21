/*Задача 29: Напишите программу, которая задаёт массив из N элементов, 
заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]*/

void SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите значение начального элемента массива: ");
int beginNumber = int.Parse(Console.ReadLine());
Console.Write("Введите значение конечного элемента массива: ");
int endNumber = int.Parse(Console.ReadLine());

SetArray(count, beginNumber, endNumber);