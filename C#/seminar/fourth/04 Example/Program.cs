int[] GetRandomBinaryArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(0, 2);
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

Console.Write($"Массив из рандомных чисел от 0..=1 ");
PrintArray(GetRandomBinaryArray());
