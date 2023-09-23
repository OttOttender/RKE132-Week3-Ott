

Console.WriteLine("Palun sisestage oma hinne.");
char userGrade = Char.Parse(Console.ReadLine().ToUpper());

if (userGrade == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (userGrade == 'B')
{
    Console.WriteLine("Väga hea!");
}
else if (userGrade == 'C')
{
    Console.WriteLine("Hea!");
}
else if (userGrade == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (userGrade == 'E')
{
    Console.WriteLine("Kasin");
}
else if (userGrade == 'F')
{
    Console.WriteLine("Puudulik");
}
else 
{
    Console.WriteLine("Vale väärtus.");
}
