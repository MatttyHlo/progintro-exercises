using System.Reflection.Metadata;

DateTimeOffset[] objects = new DateTimeOffset[4];
for (int i = 0; i < 4; i++)
{
    objects[i] = System.DateTimeOffset.FromUnixTimeMilliseconds((long)(1000 * Math.Pow(10, i)));
}
foreach (DateTimeOffset x in objects){
    Console.WriteLine(x.ToString());
}

