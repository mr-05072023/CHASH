using System;

string BinaryPerformance(int num)
{
    string binarNum = String.Empty;
    while (num != 0)
    {
        binarNum = num % 2 + binarNum;
        num /= 2;
    }
    return binarNum;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число... ");
Console.WriteLine($"{BinaryPerformance(num)}");