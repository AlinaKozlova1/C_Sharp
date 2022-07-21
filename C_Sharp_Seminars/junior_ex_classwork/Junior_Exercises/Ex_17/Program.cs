void quarter(int x, int y)
{
    if (x>0 && y>0)
    {
        Console.WriteLine("It's the first quarter!");
    }

    else if (x<0 && y>0)
    {
        Console.WriteLine("It's the second quarter!");
    }

    else if (x<0 && y<0)
    {
        Console.WriteLine("It's the third quarter!");
    }

    else if (x>0 && y<0)
    {
        Console.WriteLine("It's the fourth quarter!");
    }

    else if (x==0 && y==0)
    {
        Console.WriteLine("Please, choose another numbers");
    }
}

quarter(3,4);
quarter(-3,4);
quarter(3,-4);
quarter(-3,-4);
quarter(0,0);
