object[] GetDowblArray(int len_array)
{
    int[] array = new int[len_array];
    int[] arrayNP = new int[2];
    object[] result = {array, arrayNP};
    for (int i = 0; i < len_array; i++)
    {
        array[i] = new Random().Next(-9, 10);
        if (array[i] > 0)
        {
            arrayNP[1] += array[i];
        }
        else
        {
            arrayNP[0] += array[i];
        }
    }
    return result;
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
    Console.Write("] ");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите размер массива... ");
int[] array = (int[]) GetDowblArray(num)[0];
int[] array_value = (int[]) GetDowblArray(num)[1];
Console.Write($"Сумма положительных чисел массива "); PrintArray(array); Console.Write($"равна {array_value[1]}\n");
Console.Write($"Сумма отрицательных чисел массива "); PrintArray(array); Console.Write($"равна {array_value[0]}\n");