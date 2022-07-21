Console.Write("Enter a number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M,N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i,j] = new Random().Next(-10, 10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < N; j++)
{
    int sum = 0;
    for (int i = 0; i < M; i++)
    sum = sum + array[i,j];
    Console.Write("The {0} row is equal to {1}. ", j+1, sum);
}