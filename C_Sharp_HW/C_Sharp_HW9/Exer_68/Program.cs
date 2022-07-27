Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    if (M > 0 && N > 0) return Akkerman(M - 1, Akkerman(M, N - 1));
    return 0;
}

Console.Write(Akkerman(m, n));