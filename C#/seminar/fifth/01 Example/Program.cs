object[] GetDowblArray(int len_array, int beginValue, int endValue)
{
    int[] array = new int[len_array];
    int[] arrayNP = new int[2];
    object[] result = {array, arrayNP};
    for (int i = 0; i < len_array; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
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
int beginValue = GetInfo("Введите начало диапазона вариантов... ");
int endValue = GetInfo("Введите конец диапазона вариантов... ");
object[] array = GetDowblArray(num, beginValue, endValue);
int[] array_first = (int[]) array[0];
int[] array_value = (int[]) array[1];
Console.Write($"Сумма положительных чисел массива "); PrintArray(array_first); Console.Write($"равна {array_value[1]}\n");
Console.Write($"Сумма отрицательных чисел массива "); PrintArray(array_first); Console.Write($"равна {array_value[0]}\n");