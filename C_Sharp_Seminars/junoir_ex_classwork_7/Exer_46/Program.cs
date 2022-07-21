Console.Write("Enter a number: ");
int M = Convert.ToInt32(console.ReadLine());
Console.Write("Enter another number: ");
int N = Convert.ToInt32(console.ReadLine());
int[,] array = new int[M,N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i,j] = new Random().Next(-100, 100);
        Console.WriteLine(array[i,j]);
    }
}
