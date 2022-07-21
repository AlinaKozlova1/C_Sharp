//Console.WriteLine("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());

int number = 10;
int tNum = 0, d = 1;
    
    while (number > 0)
    {
        tNum += (number % 2) * d;
        number = number / 2;
        d = d * 10;
    }

Console.WriteLine(tNum);