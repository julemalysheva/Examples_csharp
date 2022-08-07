// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите number: ");
int number = int.Parse(Console.ReadLine());

//String Str = null;

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        //Str = string.Concat(Str + count + ", ");
        Console.Write($"{i}, ");
    }
}

//Console.WriteLine(Str.Substring(0, Str.Length - 2));
