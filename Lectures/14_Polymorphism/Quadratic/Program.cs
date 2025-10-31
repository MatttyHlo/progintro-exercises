double Discriminant(double a, double b, double c)
{
    return b * b - 4 * a * c;
}

double[] Roots(double a, double b, double c)
{
    if (Discriminant(a, b, c) < 0) throw new NegativeRootException("Can't divide by zero");
    double res1 = (-b + Math.Sqrt(Discriminant(a, b, c))) / (2 * a);
    double res2 = (-b - Math.Sqrt(Discriminant(a, b, c))) / (2 * a);
    return  [res1 , res2];
}

double[] roots = Roots(61, -3, 2);
Console.WriteLine(roots[0]);
Console.WriteLine(roots[1]);

class NegativeRootException : Exception
{
    public NegativeRootException(string message) : base(message)
    {
    }
}