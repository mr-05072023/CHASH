int[,] MultipliTwoDoubleArray(int[,] firstArray, int[,] secondArray)
{
    int firstLine = firstArray.GetLength(0);
    int firstColumn = firstArray.GetLength(1);

    int secondLine = secondArray.GetLength(0);
    int secondColumn = secondArray.GetLength(1);

    int[,] resultArray = new int[firstLine, secondColumn];

    if (firstColumn != secondLine) return new int[,] {{-1}};

    for (int k = 0; k < firstLine; k++)
    {
        for (int i = 0; i < firstColumn; i++)
        {
            for (int j = 0; j < secondColumn; j++)
            {
                resultArray[k, j] += firstArray[k, i] * secondArray[i, j];
            }
        }
    }
    return resultArray; 
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

int firstLine = GetInfo("Введите количество строк массива... ");
int firstColumn = GetInfo("Введите количество столбцов массива... ");
int firstBeginValue = GetInfo("Введите начало диапазона вариантов... ");
int firstEndValue = GetInfo("Введите конец диапазона вариантов... ");
int[,] firstArray = GetDoubleArray(firstLine, firstColumn, firstBeginValue, firstEndValue);

int secondLine = GetInfo("Введите количество строк массива... ");
int secondColumn = GetInfo("Введите количество столбцов массива... ");
int secondBeginValue = GetInfo("Введите начало диапазона вариантов... ");
int secondEndValue = GetInfo("Введите конец диапазона вариантов... ");
int[,] secondArray = GetDoubleArray(secondLine, secondColumn, secondBeginValue, secondEndValue);

PrintDoubleArray(firstArray);
Console.WriteLine();
PrintDoubleArray(secondArray);
Console.WriteLine();
PrintDoubleArray(MultipliTwoDoubleArray(firstArray, secondArray));