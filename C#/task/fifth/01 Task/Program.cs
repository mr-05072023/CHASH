int EvenNumberInArray(int num)
{
    int[] array = new int[num];
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0) count++;
    }
    PrintArray(array);
    return count;
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
    Console.Write("] -> ");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите длину массива... ");
Console.WriteLine($"{EvenNumberInArray(num)}");