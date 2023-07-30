int[] CopyArray(int num, int beginValue, int endValue)
{
    int[] array = new int[num];
    int[] copyArray = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
        copyArray[i] = array[i];
    }
    PrintArray(array);
    return copyArray;
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
PrintArray(CopyArray(num, beginValue, endValue));