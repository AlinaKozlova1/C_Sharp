int length = 8;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " "); 
}
