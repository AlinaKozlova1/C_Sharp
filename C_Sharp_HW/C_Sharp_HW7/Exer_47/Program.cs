Console.Write("Enter a number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int N = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[M,N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i,j] = new Random().NextDouble();
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
