/*Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает одно число - 
высоту елочки и рисует ее в консоли звездочками.*/

void PrintTree(int h)
{
    if (h < 3 || h % 2 == 0)
        Console.WriteLine("Некорректная высота");
    else
        for (int i = 0; i < h; i++)
        {
            for (int j = h - i; j >= 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i * 2; k ++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}

Console.Write("Введите высоту ёлочки - нечетное число >2 = ");
int height = int.Parse(Console.ReadLine());
PrintTree(height);