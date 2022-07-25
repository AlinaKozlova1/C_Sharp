
Console.Write("Enter rows quantity: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  columns quantity: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
    int[,] resultArray = new int[m, n];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return resultArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.Write("\n");

    }
    Console.Write("\n");

}

void SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1 - n; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            
            }
        }
    }
}

int[,] array = GetArray(rows, columns, 0, 11);
PrintArray(array);
SortRows(array);
PrintArray(array);

/*

int[] array = { 10, 11, 4, 1 };
for (int j = 0; j < array.Length; j++)
{
    for (int i = 0; i < array.Length - 1 - j; i++)   --> попытка вспомнить сортировку 
    {                                                      на примере обычного массива
        if (array[i] > array[i+1])
        {                                                    (just for test)
            int temp = array[i+1];
            array[i+1] = array[i];
            array[i] = temp;
        }
        
    }



}


void PrintArray(int[] anArray)
{
    
    for (int i = 0; i < anArray.Length; i++)
    {    
        Console.Write(anArray[i] + " ");
    }
}

PrintArray(array);
*/