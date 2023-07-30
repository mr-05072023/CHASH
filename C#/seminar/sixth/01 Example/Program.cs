﻿int[] ReverseArray(int num, int beginValue, int endValue)
{
    int[] array = new int[num];
    int[] reversArray = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
        reversArray[num - i - 1] = array[i];
    }
    PrintArray(array);
    return reversArray;
}

int[] BufferReverseArray(int num, int beginValue, int endValue)
{
    int[] array = new int[num];
    int buffer = 0;
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    PrintArray(array);

    for (int i = 0; i < num / 2; i++)
    {
        buffer = array[i];
        array[i] = array[num - i - 1];
        array[num - i - 1] = buffer;
    }
    
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]\n");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите длину массива... ");
int beginValue = GetInfo("Введите начало диапазона вариантов... ");
int endValue = GetInfo("Введите конец диапазона вариантов... ");
PrintArray(ReverseArray(num, beginValue, endValue));
PrintArray(BufferReverseArray(num, beginValue, endValue));