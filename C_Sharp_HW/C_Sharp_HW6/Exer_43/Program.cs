Console.WriteLine("Enter the start of the first coordinate: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the end of the first coordinate: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the start of the second coordinate: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the end of the second coordinate: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double x, y;
void intersection (double K1, double K2, double B1, double B2)
{
    x = (B2 - B1) / (K1 - K2);
    y = x * K1 + B1;
    Console.WriteLine("x = " + x + ", y =  " + y);
}

intersection(k1, k2, b1, b2);