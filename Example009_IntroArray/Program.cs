int Max(int arg1, int arg2, int arg3) //описываем функцию поиска макс.значения
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} //завершили описание функции
//              0  1  2  3  4  5  6  7  8  
int[] array = {15,72,93,484,65,16,67,88,19};

int max = Max(Max(array[0], array[1], array[2]), 
Max(array[3], array[4], array[5]), 
Max(array[6], array[7], array[8]));
//это сработает, когда значений 9, если их много или они не тройками, нужно другое решение,
//? например, в цикле перебирая все элементы массива сначала до конца
Console.WriteLine(max);
