Console.Write("Введите номер дня недели... ");
int week_number = int.Parse(Console.ReadLine());

if (week_number == 1) Console.WriteLine("Понедельник");
if (week_number == 2) Console.WriteLine("Вторник");
if (week_number == 3) Console.WriteLine("Среда");
if (week_number == 4) Console.WriteLine("Четверг");
if (week_number == 5) Console.WriteLine("Пятница");
if (week_number == 6) Console.WriteLine("Суббота");
if (week_number == 7) Console.WriteLine("Воскресенье");

switch (week_number) 
{
    case 1:
       Console.WriteLine("Понедельник");
       break;
    case 2:
       Console.WriteLine("Вторник");
       break;
    case 3:
       Console.WriteLine("Среда");
       break;
    case 4:
       Console.WriteLine("Четверг");
       break;
    case 5:
       Console.WriteLine("Пятница");
       break;
    case 6:
       Console.WriteLine("Суббота");
       break;
    case 7:
       Console.WriteLine("Воскресенье");
       break; 
}

string[] week_day = {"Понедельник", "Вторник", "Среда",
                     "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(week_day[week_number - 1]);