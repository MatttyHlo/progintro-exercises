using System.Reflection;

int seconds = 1757674303;

int years = seconds / (365 * 24 * 3600);
int days = (seconds - years * 365 * 24 * 3600) / (24 * 3600);

Console.WriteLine($"year: {1970 + years} day: {days}");
