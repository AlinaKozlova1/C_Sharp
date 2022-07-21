int[] array = { 61, 27, 43, 45, 45, 6, 17, 58 };
int n = array.Length;
int find = 45;
int index = 0;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine("index = " + index);
        break;
    }

    index++;
}
