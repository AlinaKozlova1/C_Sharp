Console.Write("Enter the first number position: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number position: ");
int b = Convert.ToInt32(Console.ReadLine());

int M = 4;
int N = 3;
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

if (a <= M && b <= N)
{
    Console.Write("Your number is " + array[(a - 1), (b - 1)]);
}
else
{
    Console.Write("Your number does not exist:(");
} 