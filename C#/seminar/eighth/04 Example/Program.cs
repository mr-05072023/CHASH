void FrequencyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[1, i] == 0) continue;
        Console.WriteLine($"{array[0, i]} встречается {array[1, i]} раз(а)");
    }
}

int[,] GetDoubleArrayAndNumberOfOccurences(int line, int column, int beginValue, int endValue)
{
    int[,] array = new int[line, column];
    
    int length = 0;
    int newBeginValue = beginValue;
    while (newBeginValue != endValue)
    {
        if (newBeginValue + 10 < endValue)
        {
            length += 10;
            newBeginValue += 10;
        }
        else
        {
            length += 1;
            newBeginValue += 1;
        }
    }

    int[,] arrayCounter = new int[2, length];
    int newTwoBeginValue = beginValue;
    for (int i = 0; i < length; i++)
    {
        arrayCounter[0, i] = newTwoBeginValue + i;
    }
    
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(beginValue, endValue);
            for (int k = 0; k < length; k++)
            {
                if (array[i, j] == arrayCounter[0, k])
                {
                    arrayCounter[1, k] += 1;
                    break;
                }
            }
        }
    }
    //PrintDoubleArray(array);
    return arrayCounter;
}

void PrintDoubleArray(int[,] array)
{   
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        Console.Write("[");
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}");
            if (j != column - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    } 
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int line = GetInfo("Введите количество строк массива... ");
int column = GetInfo("Введите количество столбцов массива... ");
int beginValue = GetInfo("Введите начало диапазона вариантов... ");
int endValue = GetInfo("Введите конец диапазона вариантов... ");
int[,] array = GetDoubleArrayAndNumberOfOccurences(line, column, beginValue, endValue);
FrequencyArray(array);