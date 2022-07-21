Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void digitSum(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum += num%10;
        num /= 10;
    }
    Console.WriteLine("The sum of your number is equal to " + sum);
}

digitSum(number);