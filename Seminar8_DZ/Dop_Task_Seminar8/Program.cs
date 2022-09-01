/*Задача со звездочкой:
Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x 
и возвращает целую часть квадратного корня от введенного числа.
4 -> 2
28 -> 5*/

int Sqrt(int num)         //пример от 28
{
    int L = 0, R = num;
    int M = (L + R) / 2;  //M=(0+28)/2 =14

    while (R - L > 1)     //28-0>1 // 14-0>1 //7-0>1 //7-3>1// 7-5>1 //6-5=1 выход со значением M=5
    {
        if (M * M <= num) //14*14>28 //7*7>28 //3*3<28 //5*5<28// 6*6<28
        {
            L = M;        //L=3 //L=5
        }
        else
        {
            R = M;        //R=14 R=7 // R=6
        }
        M = (L + R) / 2;  //M=(0+14)/2=7 //M=(0+7)/2=3 //M=(3+7)/2=5 //M=(5+7)/2=6 //M=(5+6)/2=5
    }
    return M;
}

void SqrtTwo(int number) //другой вариант нахождения кв.корня
{
    int sqrtInt = 0;
    int OstatokV = number;

    for (int i = 1; i <= OstatokV; i += 2)
    {
        Console.Write($"Вычитаем нечетное число {i} ");
        OstatokV -= i;
        Console.WriteLine($"Остаток {OstatokV}");
        sqrtInt++;
    }
    Console.WriteLine($"Целая часть корня {sqrtInt}");
}

Console.Write("Введите число: ");
int numberToSqrt = int.Parse(Console.ReadLine());
Console.WriteLine($"Целая часть квадратного корня от {numberToSqrt} = {Sqrt(numberToSqrt)}");
Console.WriteLine();
Console.WriteLine("Второй вариант поиска:");
SqrtTwo(numberToSqrt);