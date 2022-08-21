/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//в задании не уточняется, как именно нужно заполнить массив, поэтому написала функцию ввода на всякий случай, 
//но в решении использую случайные числа для простоты
double[] GetArr(int num)
{
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("введите значение элемента маcсива = ");
        arr[i] = double.Parse(Console.ReadLine());
    }
    return arr;
}

double[] SetDoubleArray(int N, int a, int b)
{
    double[] arr = new double[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().Next(a, b) + new Random().NextDouble(), 2);//для удобства восприятия округлила
    }
    return arr;
}

Console.Write("Размер массива: ");
int count = int.Parse(Console.ReadLine());

//double[] array = GetArr(count); применила бы в случае пользовательского ввода

double[] array = SetDoubleArray(count, 1, 100);
Console.WriteLine($"Массив вещественных чисел: [{String.Join(" ", array)}]");

double DiffMinMaxArray(double[] arr)
{
    double minArr = arr[0];
    double maxArr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        minArr = arr[i] < minArr ? arr[i] : minArr;
        maxArr = arr[i] > maxArr ? arr[i] : maxArr;
    }
    return maxArr - minArr;
}

Console.WriteLine($"Разница между макс. и миним. элементами массива: {Math.Round(DiffMinMaxArray(array),2)}");