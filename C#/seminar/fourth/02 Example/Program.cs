int GetCount(int number)
{
    int count = 0;
    while (number > 0)
    {
        if (number / 10 >= 0)
        {
            number /= 10;
            count +=1;
        }
    }
    return count;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число... ");
Console.WriteLine($"Количество цифр в числе {num} равно {GetCount(num)}");