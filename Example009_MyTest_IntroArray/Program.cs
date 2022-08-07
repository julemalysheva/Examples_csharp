//поиск макс. в массиве
int MaxArray(int[] Array) //метод поиска и возврата макс.в массиве
{
    int i = 0;
    int Max = Array[i];

    while (i < Array.Length)
    {
        if (Array[i] > Max) Max = Array[i];
        i++;
    }
    return Max;
}

int[] array = { 15, 72, 14593, 484, 65, 16, 67, 887 };

int res = MaxArray(array);
Console.WriteLine($"Макс.найден при помощи функции, равен {res}");


//int result = array[0];
//int i = 0;

//while (i < array.Length)
//{
//        if (array[i] > result) result = array[i];
//        i++;
//}

//Console.WriteLine(result);


//Console.WriteLine();

