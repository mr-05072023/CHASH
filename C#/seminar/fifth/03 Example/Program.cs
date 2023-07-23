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

bool SearchArray(int num, int value)
{
    bool flag = false;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-100, 101);
        if (array[i] == value) flag = true;
    }
    PrintArray(array);
    return flag;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите длину массива... ");
int value = GetInfo("Введите искомое значение... ");
Console.Write($"Значение {value} в  массиве ");
bool result = SearchArray(num,value);
if (result)
{
    Console.WriteLine("присутствует");
}   
else
{
    Console.WriteLine("отсутствует");
}
