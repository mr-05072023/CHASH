int GetSum(int num)
{
    int count = 0;
    while (num > 0)
    {
        count += num % 10;
        num /= 10;
    }
    return count;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int f_num = GetInfo("Введите число ... ");
Console.WriteLine($"Сумма цифр числа {f_num} равняется {GetSum(f_num)}");