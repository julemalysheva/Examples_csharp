/*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/
Console.WriteLine("Введите четверть:");
int a=int.Parse(Console.ReadLine());
switch(a)
{
    case 1: Console.WriteLine("x>0, y>0"); break;
    case 2: Console.WriteLine("x<0, y>0"); break;
    case 3: Console.WriteLine("x<0, y<0"); break;
    case 4: Console.WriteLine("x>0, y<0"); break;
    default: Console.WriteLine("Введена не корректная четверть"); break;
}