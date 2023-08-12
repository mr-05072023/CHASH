int GetSum(int num)
{
    if (num != 0) return num % 10 + GetSum(num / 10);
    return 0;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int num = GetInfo("Введите число для подсчёта суммы его цифр... ");
Console.WriteLine($"Сумма цифр числа = {GetSum(num)}");
