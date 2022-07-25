int x = 2;
int y = 2;
int z = 2;

void GetArray(int X, int Y, int Z)
{
    int[,,] array = new int[X, Y, Z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = new Random().Next(0, 51);
                Console.Write($"{array[i, j, l]}({i},{j},{l})    ");
            }
        }
        Console.WriteLine();
    }
}

GetArray(x, y, z);