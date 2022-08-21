/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7) Console.WriteLine("Да");
else if (dayNumber >= 1 && dayNumber <= 5) Console.WriteLine("Нет");
else Console.WriteLine("Введенное число находится вне диапазона 1..7");









