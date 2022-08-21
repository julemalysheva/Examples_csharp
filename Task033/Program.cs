/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

bool FindArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }

    return false;
}

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

Console.Write("размер маcсива =");
int num = int.Parse(Console.ReadLine());
int[] array = GetArr(num);//задаем массив

Console.Write("Число для поиска: ");
int number = int.Parse(Console.ReadLine());

//запускаем функцию, проверяя если True существует, то Да, иначе Нет
if (FindArray(array, number))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");