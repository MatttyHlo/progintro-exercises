for (double i = -5; i <= 40; i += 0.5)
{
    double fahrenheit = 32 + 9.0 / 5.0 * i;
    Console.WriteLine($"Celsius: {i:F1}, Fahrenheit: {fahrenheit:F1}");
}

Console.WriteLine("----------------------------------");

double j = -5;

while (j <= 40)
{
    double fahrenheit = 32 + 9.0 / 5.0 * j;
    Console.WriteLine($"Celsius: {j:F1}, Fahrenheit: {fahrenheit:F1}");
    j += 0.5;
}

Console.WriteLine("----------------------------------");

double k = -5;

do
{
    double fahrenheit = 32 + 9.0 / 5.0 * k;
    Console.WriteLine($"Celsius: {k:F1}, Fahrenheit: {fahrenheit:F1}");
    k += 0.5;
}
while (k <= 40);
{
    double fahrenheit = 32 + 9.0 / 5.0 * k;
    Console.WriteLine($"Celsius: {k:F1}, Fahrenheit: {fahrenheit:F1}");
    k += 0.5;
}


