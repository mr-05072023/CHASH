int GetSumValueMainDiagonal(int[,] array)
{
    int result = 0;
    int i = 0;
    while (i != array.GetLength(0) && i != array.GetLength(1))
    {
        result += array[i, i];
        Console.Write($"{array[i, i]}");
        if (i != array.GetLength(0) - 1 && i != array.GetLength(1) - 1)
        {
            Console.Write(" + ");
        }
        i++;
    }
    Console.Write(" = ");
    return result;
}

int[,] GetDoubleArray(int line, int column, int beginValue, int endValue)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(beginValue, endValue);
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
int[,] array = GetDoubleArray(line, column, beginValue, endValue);
PrintDoubleArray(array);
Console.WriteLine($"{GetSumValueMainDiagonal(array)}");