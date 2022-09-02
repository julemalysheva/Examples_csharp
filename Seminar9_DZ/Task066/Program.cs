//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumberBetween(int startNum, int endNum)
{
    if (startNum > endNum) return 0;
    return startNum + SumNumberBetween(startNum + 1, endNum);
    //или
    //if (startNum == endNum) return startNum;
    //return startNum + SumNumberBetween(startNum + 1, endNum);
}

Console.Write("M = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumberBetween(numberM, numberN));