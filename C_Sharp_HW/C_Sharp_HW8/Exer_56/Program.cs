Console.Write("Enter rows quantity: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  columns quantity: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows == columns)
{
    Console.Write("Numbers must be diffrent");
    return;
}


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

void MinSumRow(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minRow = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            minRow = i;
        }
        Console.Write("sum" + (i + 1) + " = " + sum);
        Console.WriteLine();
    }
    Console.Write("min row = " + (minRow + 1));
    Console.WriteLine();
    Console.Write("min sum = " + minSum);
}

int[,] array = GetArray(rows, columns, 0, 11);
PrintArray(array);
MinSumRow(array);