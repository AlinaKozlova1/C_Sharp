Console.WriteLine("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

/*
void triangle (int a, int b, int c)
{
    if (c < a + b)
    {
        if (b < a + c)
        {
            if (a < b + c)
            {
                Console.WriteLine("Such triangle can exist!");
            }
            else
            {
                Console.WriteLine("Such triangle can not exist:(");
            }
        }
        else
        {
            Console.WriteLine("Such triangle can not exist:(");
        }
    }
    else
    {
        Console.WriteLine("Such triangle can not exist:(");
    }
}

triangle(numberA, numberB, numberC);
*/

bool checkA = numberA < numberB + numberC;
bool checkB = numberB < numberA + numberC;
bool checkC = numberC < numberB + numberA;

if (checkA && checkB && checkC)
{
    Console.WriteLine("Such triangle can exist!");
}
else
{
    Console.WriteLine("Such triangle can not exist:(");
}