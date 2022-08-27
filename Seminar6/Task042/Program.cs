/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetBinary(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = result + Convert.ToString(num % 2);
        num /= 2;
    }

    return int.Parse(new string(result.ToCharArray().Reverse().ToArray()));

}

Console.WriteLine(GetBinary(num));
