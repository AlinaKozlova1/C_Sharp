Console.Write("Enter rows quantity: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  columns quantity: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
if (rows != columns)
{
    Console.WriteLine("Sorry, rows and colomns quantity must be same~");
    return;
}

///summery
///m - rows, n - columns
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] resultArray = new int[m,n];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRandom, maxRandom+1);
        }
    }
    return array;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        } 
        Console.Write("\n");
    
    }
    Console.Write("\n");
    
}

/*
void PrintReverseArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)   --> на случай, если кол-во строк и столбцов 
    {                                                               не совпадают
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           Console.Write(matrix[i,j] + "\t");
        }
        Console.Write("\n");
    }
    
}
*/

void PrintReverseArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[j,i] + "\t");
        } 
        Console.Write("\n");
    
    }
    Console.Write("\n");
    
}


int[,] arrayResult = GetArray(rows, columns, 0, 11);
PrintArray(arrayResult);
PrintReverseArray(arrayResult);
