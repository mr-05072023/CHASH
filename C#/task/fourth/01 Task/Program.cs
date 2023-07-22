int Exponentiation(int f_num, int s_num)
{
    int count = 1;
    for (int i = 1; i <= s_num; i++ )
    {
        count *= f_num;
    }
    return count;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int f_num = GetInfo("Введите число A... ");
int s_num = GetInfo("Введите число B... ");
Console.WriteLine($"Число {f_num} в натуральной степени {s_num} равно {Exponentiation(f_num, s_num)}");