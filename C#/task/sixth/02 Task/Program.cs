double[] PointOfIntersectionOfTwoLines(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1)/(k1 - k2);
    point[1] =  k1 * point[0] + b1;
    return point;
}

void PrintArray(double[] array)
{   
    Console.Write(" -> (");
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
            Console.Write(";");
        }
    }
    Console.Write(")\n");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = GetInfo("Введите b1... ");
int k1 = GetInfo("Введите k1... ");
int b2 = GetInfo("Введите b2... ");
int k2 = GetInfo("Введите k2... ");
PrintArray(PointOfIntersectionOfTwoLines(b1, k1, b2, k2));