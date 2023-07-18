void CalculateSquareTable(int number)
{
    for (int i = 1; i < number; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine(number * number * number + "."); 
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

CalculateSquareTable(GetInfo("Введите число для подсчёта таблицы кубов... "));

