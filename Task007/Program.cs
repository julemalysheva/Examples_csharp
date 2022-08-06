// 7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6	782 -> 2	918 -> 8

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a = number % 10;
Console.WriteLine(a);

//Дальше тренируюсь с типом String

Console.Write("Введите в строку трехзначное число: ");
String Str = Console.ReadLine();
Console.WriteLine(Str.Substring(2));