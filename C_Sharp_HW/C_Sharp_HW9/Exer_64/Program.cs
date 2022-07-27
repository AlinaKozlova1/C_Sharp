Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int num1, int num2)
{
    if (num1 == num2) return num1.ToString();
    return (num1 + ", " + PrintNumbers(num1 + 1, num2));
}

Console.Write(PrintNumbers(number1, number2));