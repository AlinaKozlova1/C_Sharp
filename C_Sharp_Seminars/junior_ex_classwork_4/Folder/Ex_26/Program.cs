Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitCount(int Num)
{
    int i = 1; 
    int div = 10;
    while (Num/div >= 1)
    {
        div*=10;
        i+=1;
    }
    Console.WriteLine("Your number consists of " + i + " digit(s)");
    return i;
}

DigitCount(number);