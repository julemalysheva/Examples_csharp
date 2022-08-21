/*Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int[] BubbleSort(int[] arr)
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
    return arr;
}


Console.Write("Введите размер массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона элементов массива: ");
int beginNumber = int.Parse(Console.ReadLine());
Console.Write("Введите окончание диапазона: ");
int endNumber = int.Parse(Console.ReadLine());

int[] array = SetArray(count, beginNumber, endNumber);
Console.WriteLine($"Первоначальный массив [{String.Join(", ", array)}]");

Console.WriteLine($"Невозрастающая сортировка [{String.Join(", ", BubbleSort(array))}]");
