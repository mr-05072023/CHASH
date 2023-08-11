int MaxValueInAllLine(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    int max = array[0, column - 1];
    int endLine = 1;
    for (int i = 0; i < line; i++)
    {
        if (max < array[i, column - 1]) 
        {
            max = array[i, column - 1];
            endLine = i + 1;
        }    
    }
    return endLine;
}

int[,] GetDoubleArray(int line, int column, int beginValue, int endValue)
{
    int[,] array = new int[line, column + 1];
    for (int i = 0; i < line; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(beginValue, endValue);
            sum += array[i,j];
            if (j == column - 1) array[i, j + 1] = sum;
        }
    }
    return array;
}

void PrintDoubleArray(int[,] array)
{   
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        Console.Write("[");
        for (int j = 0; j < column - 1; j++)
        {
            Console.Write($"{array[i, j]}");
            if (j != column - 2)
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
int[,] array = GetDoubleArray(line, column, beginValue, endValue);
PrintDoubleArray(array);
Console.WriteLine();
Console.WriteLine($"Линия {MaxValueInAllLine(array)} имеет максимальную сумму элементов.");
