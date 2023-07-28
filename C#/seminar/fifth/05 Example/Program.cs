int[] MultipliArray(int num, int beginValue, int endValue)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    
    PrintArray(array);

    int[] multipliArray = new int[num % 2 + num / 2];
    for (int i = 0; i < num / 2; i++)
    {
        multipliArray[i] = array[i] * array[num - i - 1];
        if (i + 1 == num / 2 && num % 2 == 1)
        {
            multipliArray[i + 1] = array[num / 2];
        } 
    }
    return multipliArray;
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
PrintArray(MultipliArray(num, beginValue, endValue));