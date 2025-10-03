WeekDays[][] calendar = new WeekDays[13][];
WeekDays refference = WeekDays.tuesday;

//Init
for (int month = 1; month <= 12; month++)
{
    int days = 0;
    if (month <= 7)
    {
        if (month == 2) days = 28;
        else days = (month % 2 == 1 ? 31 : 30);
    }
    else days = (month % 2 == 1 ? 30 : 31);

    calendar[month] = new WeekDays[days+1];
    for (int day = 1; day < calendar[month].Length; day++)
    {
        calendar[month][day] = (WeekDays)((int)refference +1);
        refference = (WeekDays)(((int)refference +1) % 7);
    }
}

Console.WriteLine((WeekDays)calendar[10][1]);

enum WeekDays
{
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
    sunday
}