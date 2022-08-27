/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

//Если не использовать массив
int PositiveNumbers(int countNum)
{
    int count = 0;
    for (int i = 0; i < countNum; i++)
    {
        Console.Write("number = ");
        int number = int.Parse(Console.ReadLine());
        count += number > 0 ? 1 : 0;
    }
    return count;
}

Console.Write("Количество чисел для ввода: ");
int numCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введено положительных чисел: " + PositiveNumbers(numCount));


//2 вариант решения, с массивом
int[] EnterArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PositiveNumbersOfArray(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        count += el > 0 ? 1 : 0;
    }
    return count;
}

Console.WriteLine("Работаем с массивом");
int[] myArr = EnterArray(numCount);
Console.WriteLine($"Задан массив [{String.Join(" ,", myArr)}]");
Console.WriteLine("Положительных чисел в массиве: " + PositiveNumbersOfArray(myArr));
