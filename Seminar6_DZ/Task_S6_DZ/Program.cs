/*Задача со звездочкой: Напишите программу, которая реализует обход введенного 
двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9*/

int[,] GetArray(int row, int col, int beginNum, int endNum) //задаем массив
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr) //выводим на экран
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void RoundArray(int[,] arr)
{
    int m = arr.GetLength(0); //строки
    int n = arr.GetLength(1); //столбцы

    int count = 0; //счетчик вывода значений
    int dx = 1; int dy = 0; //коэффициент изменения положения индекса строки и столбца, x y

    while (count < arr.Length)
    {

        for (int y = dy; y < n; y++) //самую нижнюю горизонталь,строку вправо, начиная со 1го эл-та (0 индекса)
        {
            Console.Write(arr[m - 1, y] + " "); count++;
        }
        for (int x = m - 2; x >= dy; x--) //начиная со 2й строки снизу крайнего правого столбца движемся вверх
        {
            Console.Write(arr[x, n - 1] + " "); count++;
        }
        for (int y = n - 2; y >= dy; y--) //начиная со 2го столбца справа до крайнего эл-та(т.е.0го индекса) 
                                          //верхней строки идем влево
        {
            Console.Write(arr[dy, y] + " "); count++;
        }
        for (int x = dx; x < m - 1; x++) //вертикаль, первый столбец от 0,1 вниз до m - 1 (включая 2ой эл-т снизу)
        {
            Console.Write(arr[x, dy] + " "); count++;
        }

        dx++; dy++; //увеличиваю положения x и y для проверки и вывода
        n--; m--; //уменьшаю значения для след.витка 
    }
}

Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());
Console.Write("Начало диапазона значений: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Окончание диапазона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.WriteLine();
RoundArray(myArray);
