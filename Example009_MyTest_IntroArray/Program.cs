//поиск макс. в массиве
int MaxArray(int[] Array) //метод поиска и возврата макс.в массиве
{
    //int i = 0;
    int Max = Array[0];

    //while (i < Array.Length) //заменила цикл на for
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] > Max) Max = Array[i];
        //i++;
    }
    return Max;
}

int MinArray(int[] Array) //метод поиска и возврата мин.в массиве
{
    int MinArray = Array[0];

    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < MinArray) MinArray = Array[i];
    }
    return MinArray;
}

int[] array = { 100015, 1, 593, 484, 8565, 10, 67, 887 };

int res = MaxArray(array);
Console.WriteLine($"Макс.найден при помощи функции, равен {res}");

res = MinArray(array);
Console.WriteLine($"Минимум найден при помощи функции, равен {res}");


//int result = array[0];
//int i = 0;

//while (i < array.Length)
//{
//        if (array[i] > result) result = array[i];
//        i++;
//}

//Console.WriteLine(result);


//Console.WriteLine();

