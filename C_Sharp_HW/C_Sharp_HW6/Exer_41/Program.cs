Console.WriteLine("Enter numbers: ");
int M = Convert.ToInt32(Console.ReadLine());
int positives = 0;

for (int i = 0; i < M; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0)
    {
        positives++;
    }
}

Console.WriteLine("The count of positive numbers is equal to {0}", positives);