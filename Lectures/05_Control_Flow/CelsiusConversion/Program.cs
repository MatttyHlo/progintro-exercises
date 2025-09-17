for (double i = -5; i <= 40; i += 0.5)
{
    double fahrenheit = 32 + 9.0 / 5 * i;
    Console.WriteLine($"C - {i} -> F - {fahrenheit.ToString("F1")}");
}