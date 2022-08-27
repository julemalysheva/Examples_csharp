/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/
int[] GetArr(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++) //в нашем случае будем вызывать с длиной 3 - стороны треугольника
    {
        Console.Write("введите значение элемента маcсива =");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int SumArray(int[] arr)
{
    int sum = 0;
    foreach (int el in arr)
    {
        sum += el;
    }
    return sum;
}

bool CheckLength(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= SumArray(arr) - arr[i])
            return true;
    }
    return false;
}

//Console.Write("размер маcсива =");
//int num = int.Parse(Console.ReadLine());
int[] array = GetArr(3);//задаем массив
Console.WriteLine($"Задан массив: [{String.Join(", ", array)}]");

if (CheckLength(array))
    Console.WriteLine("Нет, не может");
else
    Console.WriteLine("Да, может");

//на уроке решали через обычную проверку условия, см.при необходимости как описали функцию
