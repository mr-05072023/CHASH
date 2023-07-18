void CalculateSquareTable(int number)
{
    for (int i = 1; i < number; i++)
    {
        Console.Write(Math.Pow(i, 2) + ", ");
    }
    Console.WriteLine(number * number + "."); 
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

CalculateSquareTable(GetInfo("Введите число для подсчёта таблицы квадратов... "));

