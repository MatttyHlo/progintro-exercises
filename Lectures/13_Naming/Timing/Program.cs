using System.IO.Compression;

class Timing
{
    static double Fun(double x, double y)
    {
        if (y <= 1) return x;
        else return Fun(x, y - 1) * Fun(x, y - 1);
    }

    static void Main()
    {
        double x = 1.0000001;
        
        for(int y = 1; y <= 32; y++)
        {
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double result = Fun(x, y);
            long time = DateTimeOffset.Now.ToUnixTimeMilliseconds() - start;
            Console.WriteLine($"x: {x}, y: {y}, time: {time}ms, result:{result}");
        }
    }
}
