//поиск макс. в массиве, как составить функцию???
 
int[] array = { 15, 72, 93, 484, 65, 16, 67, 887, 1999 };

int result = array[0];
int i = 0;

while (i < array.Length)
{
        if (array[i] > result) result = array[i];
        i++;
}

Console.WriteLine(result);
