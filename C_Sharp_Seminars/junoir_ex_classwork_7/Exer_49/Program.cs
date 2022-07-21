Console.Write("Enter a number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M,N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i,j] = i + j;
        if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
        {
            array[i,j] = array[i,j] * array[i,j];
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
