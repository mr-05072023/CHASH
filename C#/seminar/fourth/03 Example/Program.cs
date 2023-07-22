int GetSum(int num)
{
    int count = 1;
    for (int i = 1; i <= num; i++)
    {
        count *= i;
    }
    return count;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число... ");
Console.WriteLine($"Сумма чисел от 1 до {num} равно {GetSum(num)}");