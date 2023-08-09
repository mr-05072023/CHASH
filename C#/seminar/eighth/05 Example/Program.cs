int[,] DeliteLineAndColumnDoubleArray(object[] objArray)
{
    int[,] array = (int[,]) (objArray[0]);
    int[] index = (int[]) (objArray[1]);

    int line = array.GetLength(0);
    int column = array.GetLength(1);

    int[,] deliteArray = new int[line - 1,column - 1];
    int k = 0;
    
    for (int i = 0; i < line; i++)
    {   
        int m = 0;
        if (i == index[0]) continue;
        for (int j = 0; j < column; j++)
        {
            if (j == index[1]) continue;
            deliteArray[k, m] = array[i, j];
            m++;
        }
        k++;
    }
    return deliteArray;
}

object[] GetObjectArray(int line, int column, int beginValue, int endValue)
{
    int[,] array = new int[line, column];
    int[] index = new int[2];
    object[] objArray = {array, index};
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(beginValue, endValue);
            if (index[0] == 0 && index[1] == 0 && array[i, j] == beginValue) { index[0] = i; index[1] = j; }
        }
    }
    PrintDoubleArray(array);
    Console.WriteLine();
    return objArray;
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
object[] array = GetObjectArray(line, column, beginValue, endValue);
PrintDoubleArray(DeliteLineAndColumnDoubleArray(array));