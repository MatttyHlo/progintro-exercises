for (int i = 0; i < 10; i++)
{
    Kitten kitten = new Kitten(i * 2);
}
Console.WriteLine(Kitten.count);
class Kitten
{
    public double cuteness;
    public static int count = 0;
    public Kitten(double cuteness)
    {
        this.cuteness = cuteness;
        count++;
    }
}
