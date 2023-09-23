

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
//switch kui v22rtus on kindel number (v2i ka avaldis), mida on rohkem kui kaks
switch (weekDay) 
{
case 0:
        Console.WriteLine("It's Sunday!");
        break;
    case 1:
        Console.WriteLine("It's Monday!");
        break;
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday!");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday!");
        break;
        default: Console.WriteLine("Oops. Your calendar might be broken.");
        break;
}       

Console.WriteLine("Have a nice day!");