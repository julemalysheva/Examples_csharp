/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] MinusArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }

    //Console.WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}

Console.Write("размер маcсива =");
int num = int.Parse(Console.ReadLine());
int[] array = GetArr(num);//задаем массив
MinusArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetArr(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("введите значение элемента маcсива =");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}