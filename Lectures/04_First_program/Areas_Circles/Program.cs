int[] rads = new int[] { 1, 3, 5 };

foreach (int r in rads)
{
    double area = AreaOfCircle(r);
    Console.WriteLine($"Area of circle with radius {r} is {area}");
}

static double AreaOfCircle(int radius)
{
    return (Math.PI * radius * radius);
}
