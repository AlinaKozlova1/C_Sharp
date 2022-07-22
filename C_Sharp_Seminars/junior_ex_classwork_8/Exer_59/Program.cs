Console.Write("Enter rows quantity: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  columns quantity: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

int minValue = int.MaxValue; //array[0,0]
int indexRowsMin = 0;  // номер строчки с минимальным значением
int indexColumnsMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 11);
        Console.Write(array[i, j] + "\t");
        if (minValue > array[i, j])
        {
            minValue = array[i, j];
            indexRowsMin = i;
            indexColumnsMin = j;
        }
    }
    
    Console.WriteLine();
}

Console.Write("min = " + minValue);
Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    if(i != indexRowsMin)
    {
        for (int j = 0; j < columns; j++)
        {
            if(j != indexColumnsMin)
            {
                Console.Write(array[i,j] + "\t");
            }
        }
    }
    Console.WriteLine();
    
}


