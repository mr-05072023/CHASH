int SearchRay(int num, int beginValue, int endValue)
{
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
        if (array[i] <= 99 && array[i] >= 10) count += 1;
    }
    return count;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите длину массива... ");
int beginValue = GetInfo("Введите начало диапазона вариантов... ");
int endValue = GetInfo("Введите конец диапазона вариантов... ");
Console.WriteLine($"Значение в диапазоне от 1 до 99 раз, повторяется в  массиве {SearchRay(num, beginValue, endValue)} раз.");