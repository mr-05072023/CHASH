void SearchInDoubleArrayValue(int[,] array, int num)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    byte flag = 0;
    int iSearch = 0;
    int jSearch = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == num)
            {
                flag++; 
                iSearch = i;
                jSearch = j;
                break;
            }
        }
        if (flag == 1) break;
    }
    if (flag == 1)
    {
        Console.WriteLine($"Такое число в массиве есть, первое вхождение [{iSearch},{jSearch}]");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

void SearchInDoubleArrayLineColumn(int[,] array, int iSearsh, int jSearsh)
{   
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    byte flag = 0;
    int value = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i == iSearsh - 1 && j == jSearsh - 1)
            { 
                flag++; 
                value = array[i, j]; 
                break; 
            }
        }
       if (flag == 1) break;
    }
    if (flag == 1)
    {
        Console.WriteLine($"{value}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    
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

int lineSearch = GetInfo("Введите номер искомой СТРОКИ массива... ");
int columnSearch = GetInfo("Введите номер искомого СТОЛБЦА массива... ");

SearchInDoubleArrayLineColumn(array, lineSearch, columnSearch);

int numSearch = GetInfo("Введите искомое значение в массиве... ");

SearchInDoubleArrayValue(array, numSearch);