int[] RandomArray ()
{
    int[] result = new int[8];
    for (int i = 0; i<8; i++)
    {
        int A = new Random().Next(0,2);
        result[i] = A;
        Console.WriteLine(result[i]);
    }
    return result;
}

RandomArray();