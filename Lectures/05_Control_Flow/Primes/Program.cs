//Implementation without arrays
int max = 0;
for (int i = 2; i <= 1000000; i++)
{
    bool found = false;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0) { found = true; break; }
    }
    if (!found) max = i;
}  
Console.WriteLine(max);
