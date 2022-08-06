// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Write("number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("number2 = ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("number3 = ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Максимум равен {max}");