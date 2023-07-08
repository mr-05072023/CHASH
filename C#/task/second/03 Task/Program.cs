Console.Write("Введите цифру дня недели... ");
int number_day = int.Parse(Console.ReadLine());

string SearchDayWeek(int number)
{
    return number == 6 || number == 7 ? 
    "Выходной день" : 
    "Будний день";
}

Console.WriteLine(SearchDayWeek(number_day));