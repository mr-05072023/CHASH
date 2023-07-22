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

int[] GetRandomArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

int[] GetArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = GetInfo($"Введите {i} число массива... ");
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число значений в массиве... ");
PrintArray(GetArray(num));
Console.WriteLine("Рандомный товарищ");
PrintArray(GetRandomArray(num));