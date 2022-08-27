/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
//мой код:
int[] SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

int[] ReverseArray(int[] arr) //меняем элементы картежами
{
    int j = arr.Length - 1;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
        j--;
    }
    return arr;
}

int[] ReverseArrayTwo(int[] arr) //переписали в новый массив с конца текущего в начало нового
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - 1 - i];
    }
    return result;
}

int[] myArr = SetArray(10, 1, 20);//задаем массив произвольно

Console.WriteLine($"Задан массив: [{String.Join(", ", myArr)}]");
//ReverseArray(myArr); //применяем первую функцию
//Console.WriteLine($"Разворот массива: [{String.Join(", ", myArr)}]");
Console.WriteLine($"Разворот массива два: [{String.Join(", ", ReverseArrayTwo(myArr))}]");//работает 2ая ф-ция