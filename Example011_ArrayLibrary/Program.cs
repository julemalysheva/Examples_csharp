//описываем метод для заполнения массива
void FillArray(int[] Collection)
{
    int lentch = Collection.Length;
    int index = 0;
    while (index < lentch)
    {
        Collection[index] = new Random().Next(1, 10);//кладем в каждое след.значение случайное число из диапазона 1..10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] Collection, int find)//описываем метод поиска find в массиве Collection
{
    int count = Collection.Length;
    int index = 0;
    int position = -1;//переменная, куда сохраним результат для вывода значения функции
    //т.к. мы ищем индекс искомого числа, если его не окажется, будет неправильно выводить 0, поэтому переменной
    //присваиваем значение -1, такого индекса не бывает и мы тогда понимаем, что искомое число не найдено
    while (index < count)
    {
        if (Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//создаем новый массив с 10 элементами, изначально все нули 0 - определяем массив

FillArray(array);//используем созданный метод для заполнения объявленного выше массива
PrintArray(array);//используем созданный метод для вывода на экран объявленного выше массива
Console.WriteLine();
int pos = IndexOf(array,9);//создали переменную и с помощью нашего метода нашли значение
Console.WriteLine(pos);//выводим это значение после отработки метода

