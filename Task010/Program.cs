/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
//второй вариант решения:
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 < 10 && num / 100 > 0) //проверяю, 3х-значное ли число
{
    int des = num % 100 / 10; //получаем 2ую цифру целочисленным делением двузначного числа, 
    //полученного как остаток от деления на 100
    Console.WriteLine(des);
}
else Console.WriteLine("Число не является трехзначным");


/*Console.WriteLine("Введите трехзначное число: ");
int num = Math.Abs(int.Parse(Console.ReadLine())); 
int Ed = num % 10;//сколько единиц
int Sotni = num / 100;//сколько сотен
if (Sotni<1 || Sotni>=10) 
Console.WriteLine("Число не является трехзначным");
else
{
    int desCol = (num - Ed - Sotni * 100) / 10;
    Console.WriteLine(desCol);
}*/


