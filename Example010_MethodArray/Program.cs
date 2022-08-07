int [] array={71,29,34,4,45,66,4,85};
int index=0;
int find=4;

while (index<array.Length)
{
    if (array[index]==find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
