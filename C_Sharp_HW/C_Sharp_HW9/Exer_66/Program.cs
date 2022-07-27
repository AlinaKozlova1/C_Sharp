Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return sum;
    return (sum + SumNumbers(num1 + 1, num2));
}

Console.Write(SumNumbers(number1, number2));
