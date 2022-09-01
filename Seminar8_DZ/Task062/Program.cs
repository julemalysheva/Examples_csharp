/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] SetArrayInSpiral(int sizeRowCol, int startNumber)
{
    int[,] arr = new int[sizeRowCol, sizeRowCol];
    int m = 0;
    int step = 0;
    while (step < sizeRowCol / 2)
    {
        //Заполнение верхней горизонтальной линии
        for (int i = 0; i < sizeRowCol - m; i++) //верхнюю строку полностью заполняем
        {
            arr[step, i + step] = startNumber;
            startNumber++;
        }
        //Заполнение правой вертикальной линии    
        for (int i = step + 1; i < sizeRowCol - step - 1; i++) //не заполняем крайний нижний элемент
        {
            arr[i, sizeRowCol - 1 - step] = startNumber;
            startNumber++;
        }
        //Заполнение нижней горизонтальной линии
        for (int i = sizeRowCol - 1 - step; i >= step + 1; i--) //не заполняем крайний левый элемент
        {
            arr[sizeRowCol - 1 - step, i] = startNumber;
            startNumber++;
        }
        //Заполнение левой вертикальной линии
        for (int i = sizeRowCol - (step + 1); i > step; i--) //от 3 до 1 вкл, далее от 2 до 2 вкл
        {
            arr[i, step] = startNumber;
            startNumber++;
        }
        step++;
        m += 2;
    }

    if (sizeRowCol % 2 != 0)                           //если размер не четный 
    arr[sizeRowCol / 2, sizeRowCol / 2] = startNumber;//добавляем в центр нужное значение

    return arr;                                                                 
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задаем массив");
Console.Write("Введите размер строк и столбцов: ");
int SizeMatrix = int.Parse(Console.ReadLine());
int[,] myArray = SetArrayInSpiral(SizeMatrix, 1);
PrintArray(myArray);