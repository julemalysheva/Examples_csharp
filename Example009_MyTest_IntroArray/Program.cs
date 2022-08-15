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

int[] array = { 100015, 5472, 593, 484, 8565, 16, 67, 887 };

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

