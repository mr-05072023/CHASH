﻿int DefQuarter(int xPoint, int yPoint)
{
    if (xPoint > 0 && yPoint > 0) return 1;
    if (xPoint < 0 && yPoint > 0) return 2;
    if (xPoint < 0 && yPoint < 0) return 3;
    if (xPoint > 0 && yPoint < 0) return 4;
    return -1;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

int xPoint = GetInfo("Введите координату x ");
int yPoint = GetInfo("Введите координату y ");

Console.WriteLine($"Это {DefQuarter(xPoint, yPoint)} четверть!");