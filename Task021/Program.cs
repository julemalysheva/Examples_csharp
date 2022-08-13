/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/
//Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
//AB = √(xb - xa)2 + (yb - ya)2

Console.Write("Введите координату xa = ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите координату ya = ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите координату xb = ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите координату yb = ");
int yb = int.Parse(Console.ReadLine());

double distanceAB = Math.Sqrt(Math.Pow(xb - xa,2)+Math.Pow(yb - ya,2));
Console.WriteLine($"Расстояние между AB в 2D пространстве: {distanceAB:f3}");
