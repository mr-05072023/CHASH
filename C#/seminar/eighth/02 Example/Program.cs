int[,] ReverseLineOnColumnDoubleArray(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    
    if (line != column)
    {   
        Console.WriteLine("Невозможно поменять строки и столбцы! Информация теряется!");
        return new int[,] {{-1},};
    }
    int k = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0 + k; j < column; j++)
        {
            int temporary = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temporary;
        }
        k++;
    }
    return array;
    
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
Console.WriteLine();
PrintDoubleArray(ReverseLineOnColumnDoubleArray(array));