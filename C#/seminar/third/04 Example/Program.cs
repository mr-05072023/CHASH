int Square(int a)
{
    return a*a;
}

void SearchDistance()
{
    Console.WriteLine("Введите координаты точек...");
    int[] pointArray = new int[4];
    int count = 0;
    for (int i = 1; i <= 2; i++)
    {
        Console.WriteLine($"Введите {i} точку...");
        Console.Write($"x_{i} = ");
        pointArray[count] = Convert.ToInt32(Console.ReadLine());
        count++;
        Console.Write($"y_{i} = ");
        pointArray[count] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
    int xSquare = Square(pointArray[0] - pointArray[2]);
    int ySquare = Square(pointArray[1] - pointArray[3]);
    double distance = Math.Sqrt(xSquare + ySquare);
    Console.WriteLine($"Дистанция от А({pointArray[0]}, {pointArray[1]}) до точки В({pointArray[2]}, {pointArray[3]}) равна {distance}");
}

SearchDistance();