using System.Security.Cryptography.X509Certificates;

class Circle {
    private double x, y;
    private double d;
    public Circle(double x, double y, double diameter)
    {
        this.x = x;
        this.y = y;
        this.d = diameter;
    }

    public void SetX(double x)
    {
        this.x = x;
    }
    public double GetX()
    {
        return x;
    }
    public void SetY(double y)
    {
        this.y = y;
    }
    public double GetY()
    {
        return y;
    }
    public void SetD(double d)
    {
        this.d = d;
    }
    
    public double GetD()
    {
        return d;
    }
}
class TestCircle
{
    static void Main(string[] args)
    {
        Coordinate cords = new Coordinate(1.24, 2.83);
        Circle c = new Circle(cords.x, cords.y, 12.7);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetD());
        c.SetD(1.37);
        c.SetX(0.65);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " di=" + c.GetD());
    }
}

class Coordinate
{
    public double x;
    public double y;

    public Coordinate(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}
