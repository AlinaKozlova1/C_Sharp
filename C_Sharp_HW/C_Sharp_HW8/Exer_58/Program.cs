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

void ArrayMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            product[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(product[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array1 = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);
Console.WriteLine("The first array: ");
PrintArray(array1);
Console.WriteLine("The second array: ");
PrintArray(array2);
Console.WriteLine("The multiplication: ");
ArrayMultiplication(array1, array2);

