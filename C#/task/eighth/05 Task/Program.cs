int[,] GetSpireArray()
{
    int[,] array = new int[4,4];
    int line = array.GetLength(0);
    int column = array.GetLength(1);

    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= line * column)
    {
        array[i, j] = k;
        if (i == Ibeg && j < column - Jfin - 1)
            ++j;
        else if (j == column - Jfin - 1 && i < line - Ifin - 1)
            ++i;
        else if (i == line - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;
    
    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != column - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
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
            if (array[i, j] < 10) Console.Write($"0{array[i, j]}");
            if (array[i, j] >= 10) Console.Write($"{array[i, j]}");
            if (j != column - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    } 
}

PrintDoubleArray(GetSpireArray());