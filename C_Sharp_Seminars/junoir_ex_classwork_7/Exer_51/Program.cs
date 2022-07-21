Console.Write("Enter a number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M,N];
int diagonal = 0;

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i,j] = new Random().Next(-10, 10);
        if (i == j)
        {
            diagonal += array[i,j];
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("diagonal sum = " + diagonal);
