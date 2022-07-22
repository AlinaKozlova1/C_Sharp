Console.Write("Enter a rows quantity: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

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

void ChangeRows(int[,] matrix)
{
    int lastRowNumber = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[lastRowNumber, i];
        matrix[lastRowNumber, i] = temp;
    }


}

int[,] arrayResult = GetArray(rows, columns, 0, 11);
PrintArray(arrayResult);
ChangeRows(arrayResult);
PrintArray(arrayResult);

/*
Console.Write("blabla" + array); --> конкатенация (процесс сложения строк)
Console.Write($"blabla {array}"); --> интерполяция (видоизменение строки)

Лайфхак для двумерных массивов:
int array = {1,2,3,4,5}
Console.WriteLine($"[{String.Join(", ", array)}]"
*/