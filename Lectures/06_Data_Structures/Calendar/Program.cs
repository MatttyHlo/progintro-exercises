int[] year = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
int[] leapYear = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

for (int i = 2000; i <= 2020; i++)
{
    int[] pointer = (i % 4 == 0 ? leapYear : year);
    for (int j = 0; j < 12; j++)
    {
        Console.WriteLine($"In year {i} {j + 1} month has {pointer[j]} days");
    }
}


