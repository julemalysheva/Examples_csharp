/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] fibonacci(int num)
{
    int[] f = new int[num];
    f[0] = 0;
    f[1] = 1;

    for (int i = 2; i < num; i++)
    {
        f[i] = f[i - 1] + f[i - 2];

    }
    return f;
}

Console.WriteLine($"Первые {num} чисел Фибоначчи: [{String.Join(", ", fibonacci(num))}]");
