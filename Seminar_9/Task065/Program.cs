/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

void PrintNumberBetween(int M, int N)
{
    if (M > N) return;
    PrintNumberBetween(M, N-1); 
    Console.Write(N + ", ");
}

string PrintNumToStringBetween(int startNum, int endNum)
{
    if (startNum == endNum) return startNum.ToString();
    return startNum + " " + PrintNumToStringBetween(startNum + 1, endNum);
}

Console.Write("M = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numberN = int.Parse(Console.ReadLine());
PrintNumberBetween(numberM, numberN);
Console.WriteLine();
Console.WriteLine(PrintNumToStringBetween(numberM, numberN));
