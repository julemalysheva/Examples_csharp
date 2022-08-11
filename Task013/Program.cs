/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число ");
int num = Math.Abs(int.Parse(Console.ReadLine()));
int Sotni = num / 100;//сколько сотен
if (Sotni < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (Sotni >= 1 && Sotni < 10)
{
    Console.WriteLine(Sotni);
}
else Console.WriteLine(Sotni % 10);