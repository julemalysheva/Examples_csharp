// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите number: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
String Str = null;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Str = string.Concat(Str + count + ", ");
        //Console.Write($"{count}, ");
    }
    count++;
}

Console.WriteLine(Str.Substring(0, Str.Length - 2));
