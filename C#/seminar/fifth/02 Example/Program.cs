object[] ReversValueArray(int num, int beginValue, int endValue)
{
 int[] firstArray = new int[num];
 int[] reversArray = new int[num];
 object[] result = {firstArray, reversArray};
 for (int i = 0; i < num; i++)
 {
    firstArray[i] = new Random().Next(beginValue, endValue);
    reversArray[i] = -firstArray[i];
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

int num = GetInfo("Введите длину массива... ");
int beginValue = GetInfo("Введите начало диапазона вариантов... ");
int endValue = GetInfo("Введите конец диапазона вариантов... ");
object[] array = ReversValueArray(num, beginValue, endValue);
int[] greatArray = (int[]) array[0];
int[] reversArray = (int[]) array[1];
PrintArray(greatArray); Console.Write(" -> "); PrintArray(reversArray); Console.WriteLine("");