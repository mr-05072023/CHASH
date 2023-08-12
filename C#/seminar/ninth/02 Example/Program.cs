void GetSequenceOfNaturalNumbers(int numBeg, int numFin, int temporary)
{  
    if (temporary == numBeg) Console.Write($"\"");
    Console.Write($"{temporary}");
    if (temporary < numFin) Console.Write($", ");
    if (temporary != numFin) GetSequenceOfNaturalNumbers(numBeg, numFin, temporary + 1);
    if (temporary == numFin) Console.Write($"\"");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numBeg = GetInfo("Введите начальное число последовательности натуральных чисел... ");
int numFin = GetInfo("Введите конечное число последовательности натуральных чисел... ");
int temporary = numBeg;
GetSequenceOfNaturalNumbers(numBeg, numFin, temporary);
Console.WriteLine();