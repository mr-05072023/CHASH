string SearchInQuarter(int number)
{
    if (number == 1) return "для x [0; +∞), для y [0; +∞)" ;
    if (number == 2) return "для x (-∞; 0], для y [0; +∞)" ;
    if (number == 3) return "для x (-∞; 0], для y (-∞; 0]" ;
    if (number == 4) return "для x [0; +∞), для y (-∞; 0]" ;
    return "-1";
}

void VoiceDigital()
{
    Console.Write("Введите номер четверти...");
    int number = Convert.ToInt32(Console.ReadLine());
    string value = SearchInQuarter(number);
    Console.WriteLine($"В четверти {number} диапазон значений {value}");
}

VoiceDigital();