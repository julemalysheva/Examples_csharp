//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до M. (решила сделать эту задачу с выводом наоборот - по убыванию от N до M)

string PrintNumToStringBetween(int startNum, int endNum) //по аналогии с решением на семинаре
{
    if (endNum == startNum) return endNum.ToString();
    return endNum + ", " + PrintNumToStringBetween(startNum, endNum-1);
}

void PrintNumberBetween(int endNum, int startNum) //так тоже работает))
{
  if (startNum > endNum) return;
  PrintNumberBetween(endNum, startNum + 1);
  Console.Write(startNum + ", ");
}

Console.Write("M = ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("N = ");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumToStringBetween(numberM, numberN));
Console.WriteLine("Второй вариант рекурсии");
PrintNumberBetween(numberN, numberM);