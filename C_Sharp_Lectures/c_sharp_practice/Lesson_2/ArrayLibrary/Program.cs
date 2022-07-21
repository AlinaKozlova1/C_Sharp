void FillArray(int[] collection)
// this method doesn't return a value. And, of course, we don't use return statement
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return  position;
}

int[] array = new int[10];  // make a new array, which will include 10 items
FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);