// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите значение number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение number2 = ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число {number1}, меньшее число {number2}");
}
else if (number2 > number1)
{
    Console.WriteLine($"Большее число {number2}, меньшее число {number1}");
}
else
{
    Console.WriteLine("Числа равны");
}