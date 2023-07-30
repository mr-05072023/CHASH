int[] FibonacciSequence(int num)
{
    int[] fibinacci = new int[num];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
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

int num = GetInfo("Введите число... ");
PrintArray(FibonacciSequence(num));