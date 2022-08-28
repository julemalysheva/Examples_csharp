/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[,] EnterArray(int row, int col)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("Введите значение: ");
            arr[i, j] = double.Parse(Console.ReadLine());
        }
    return arr;
}

void PointOfIntersection(double[,] arr)
{
    double x = (arr[1, 0] - arr[0, 0])
             / (arr[0, 1] - arr[1, 1]);
    double y = arr[0, 1] * x + arr[0, 0];
    Console.WriteLine($"({x}; {y})");
}

Console.WriteLine("Введите последовательно значения b1, k1, b2, k2");
double[,] myArr = EnterArray(2, 2);
PointOfIntersection(myArr);


/* либо так, если без двумерного массива:
void PointOfIntersection(double b1,double k1, double b2, double k2) 
  { 
   double x = (b2 - b1) / (k1 - k2); 
   double y = k1 * x + b1; 
   Console.WriteLine($"({x}; {y})"); 
  } 
  
  Console.Write("b1= "); 
  int b1=int.Parse(Console.ReadLine()); 
  Console.Write("k1= "); 
  int k1=int.Parse(Console.ReadLine()); 
  Console.Write("b2= "); 
  int b2=int.Parse(Console.ReadLine()); 
  Console.Write("k2= "); 
  int k2=int.Parse(Console.ReadLine()); 
  PointOfIntersection(b1,k1,b2,k2);*/