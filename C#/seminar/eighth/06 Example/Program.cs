void PrintTrianglePascale(int[,] triangle)
{
    int line = triangle.GetLength(0);
    int column = triangle.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        int k = 0;
        if (line % 2 == 0) k = line - i;
        if (line % 2 != 0) k = line - i;
        while(k != 0)
        {
            Console.Write(" ");
            k--;
        }
        for (int j = 0; j < column; j++)
        {
            if (triangle[i, j] == 0) continue;
            Console.Write($"{triangle[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] GetTrianglePascale(int num)
{
    int[,] arrayPascale = new int[num + 1, num + 1];
    int line = arrayPascale.GetLength(0);
    int column = arrayPascale.GetLength(1);
    arrayPascale[0, 0] = 1;
    arrayPascale[1, 0] = 1;
    arrayPascale[1, 1] = 1;
    for (int i = 2; i < line; i++)
    {
        for (int j = 0; j < i / 2 + 1; j++)
        {
            if (j == 0) { arrayPascale[i, j] = 1; arrayPascale[i, i] = 1; continue; }
            if (j == 1) { arrayPascale[i, j] = i; arrayPascale[i, i - 1] = i; continue; }
            arrayPascale[i, j] = arrayPascale[i - 1, j] + arrayPascale[i - 1, j - 1];
            arrayPascale[i, i - j] = arrayPascale[i - 1, j] + arrayPascale[i - 1, j - 1];
            
        }
    }
    return arrayPascale;
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

int line = GetInfo("Введите количество строк треугольника Паскаля... ");
PrintTrianglePascale(GetTrianglePascale(line));
//PrintDoubleArray(GetTrianglePascale(line));