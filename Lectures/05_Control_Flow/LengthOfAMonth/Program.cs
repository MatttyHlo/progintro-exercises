using System.Security.Cryptography.X509Certificates;

int month = 8;
int days = 0;
if (month <= 7)
{
    if (month == 2) days = 28;
    else days = (month % 2 == 1 ? 31 : 30);
}
else days = (month % 2 == 1 ? 30 : 31);

Console.WriteLine(days);