﻿Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
int xa = 40, ya = 1, //определили точки треугольника
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //поставили в эти точки +
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; //определяем точку, дальше меняем ее в цикле
int count = 0;

while (count < 10000) //генерируем случайное число из выбранного диапазона точек, 
{
    int what = new Random().Next(0, 3); //0.1.2 выбираем одну из трех вершин

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}

