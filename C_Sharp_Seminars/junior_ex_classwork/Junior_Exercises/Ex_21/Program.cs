double distance(double xb, double xa, double yb, double ya)

{
    if (xa==xb && ya==yb)
    {
        Console.WriteLine("The distanse is equal to zero");
        return 0;
    }
    else 
    {
        double S = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya, 2));
        Console.WriteLine("The distanse is equal to " + S);
        return S;
    }
    
}

distance(7,3,5,2);
distance(7,7,3,3);

