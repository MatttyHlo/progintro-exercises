double Discriminant(double a, double b, double c)
{
    return b * b - 4 * a * c;
}

double[] Roots(double a, double b, double c)
{
    double res1 = (-b + Math.Sqrt(Discriminant(a, b, c))) / (2 * a);
    double res2 = (-b - Math.Sqrt(Discriminant(a, b, c))) / (2 * a);
    return  [res1 , res2];
}

double[] roots = Roots(1, -3, 2);
Console.WriteLine(roots[0]);
Console.WriteLine(roots[1]);
