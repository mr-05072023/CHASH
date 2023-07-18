int Square(int a)
{
    return a*a;
}

void SearchDistance()
{
    Console.WriteLine("Введите координаты точек...");
    int[] pointArray = new int[6];
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
        Console.Write($"z_{i} = ");
        pointArray[count] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
    int xSquare = Square(pointArray[0] - pointArray[3]);
    int ySquare = Square(pointArray[1] - pointArray[4]);
    int zSquare = Square(pointArray[2] - pointArray[5]);
    double distanceOne = Math.Sqrt(xSquare + ySquare + zSquare);
    Console.WriteLine($"Дистанция от А({pointArray[0]}, {pointArray[1]}, {pointArray[2]}) до точки В({pointArray[3]}, {pointArray[4]}, {pointArray[5]}) равна {distanceOne}");
}

SearchDistance();