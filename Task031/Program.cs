/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
 сумма отрицательных равна -20.*/

int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int[] MyArray = SetArray(12, -9, 10);
Console.WriteLine(String.Join(" ", MyArray));
SumArr(MyArray);

void SumArr(int[] arr)
{
    int positivSum = 0;
    int negativeSum = 0;
    foreach (int el in arr)
    {
        positivSum += (el > 0) ? el : 0;
        negativeSum += (el < 0) ? el : 0;
    }
    Console.WriteLine($"Сумма положительных чисел в массиве: {positivSum}, сумма отрицательных: {negativeSum}");
}