int GetQuantityMoreZero()
{
    int count = 0;
    while(true)
    {   
        Console.WriteLine("Введите число для продолжения работы, или символ(ы) для завершения работы...");
        string str = Console.ReadLine();
        if (int.TryParse(str, out int num)) { if (num > 0) count += 1; continue; }
        Console.Write("... Вы прервали ход программы, результат -> ");
        break;
    }
    return count;
}
Console.WriteLine($"{GetQuantityMoreZero()}");