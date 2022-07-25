int r = 4;
int c = 4;

int[,] Spiral (int rows, int columns)
{
    int number = 0;
    int[,] spiralArray = new int[rows, columns];
    int k = 0; // the variable allows to move inside the square 
    while (number <= rows*columns)
    {
        
        for (int i = k; i < 1 + k; i++)             //the 1st row
        {
            for (int j = k; j < columns - k; j++)
            {
                number += 1;
                spiralArray[i,j] = number;
                if (number == rows * columns) return spiralArray;
            }
        }

        for (int j = columns - 1 - k; j < columns - k; j++)   // the last column
        {
            for (int i = 1 + k; i < rows - k; i++)
            {
                number += 1;
                spiralArray[i,j] = number;   
            }
            if (number == rows * columns) return spiralArray;
            
        }

        for (int i = rows - 1 - k; i < rows - k; i++) // the last row
    {
            for (int j = columns - 2 - k; j >= k; j--)
            {
                number += 1;
                spiralArray[i,j] = number;
            }
            if (number == rows * columns) return spiralArray;
    }

        for (int j = k; j < columns - 3 + k; j++)   // the 1st column (the perimetre has almost done)
        {
            for (int i = rows - 2; i > k; i--)
            {
                number += 1;
                spiralArray[i,j] = number;
            }
            if (number == rows * columns) return spiralArray;
        }

         k++;
    }

    return spiralArray;

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


int [,] arr = Spiral(r, c);
PrintArray(arr);


