Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a power of this number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

void riseToPower(double a, double b)  //изменила double на void
{                                   // мне казалось, тип double необходим для использования Math.Pow,
    double result = 0;              //но в итоге программа сработала и без него:)
    
    for (int i = 0; i < b; i++)
    {
        result = Math.Pow(a, b);
       
    }
     Console.WriteLine(a + " to the " + b + " power is equal to " + result);
     
}
    
riseToPower(numberA, numberB);
