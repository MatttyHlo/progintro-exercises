enum Direction
{
    North,
    South,
    East,
    West
}
class Program
{
    static void Main()
    {
        Direction compas = Direction.South;

        if (compas == Direction.South) Console.WriteLine("South");
    }
}


