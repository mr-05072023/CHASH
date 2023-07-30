bool EqualityTriangle(int firstSide, int secondSide, int thirdSide)
{
    if (firstSide + secondSide < thirdSide) return false;
    if (firstSide + thirdSide < secondSide) return false;
    if (thirdSide + secondSide < firstSide) return false;
    return true;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int firstSide = GetInfo("Введите первую сторону... ");
int secondSide = GetInfo("Введите вторую сторону... ");
int thirdSide = GetInfo("Введите третью сторону... ");
Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} -> {EqualityTriangle(firstSide, secondSide, thirdSide)}");