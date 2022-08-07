//описываем функцию поиска макс.значения
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//завершили описание функции

int a1 = 25, b1 = 1479, c1 = 45,
    a2 = 52, b2 = 91, c2 = 85,
    a3 = 73, b3 = 655, c3 = 75;
//далее мы применяем выше описанную функцию для поиска макс.среди первой тройки, второй, третьей и среди финалистов
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);//ищем макс среди макс в трех тройках

//внутри аргумента можем передать функцию:

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
