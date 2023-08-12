void GetSequenceOfNaturalNumbers(int temporary, int constant)
{
    if (temporary == 1) Console.Write($"\"");
    Console.Write($"{temporary}");
    if (temporary < constant) Console.Write($", ");
    if (temporary != constant) GetSequenceOfNaturalNumbers(temporary + 1, constant);
    if (temporary == constant) Console.Write($"\"");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numBeg = 1;
int constant = GetInfo("Введите конечное число последовательности натуральных чисел... ");
GetSequenceOfNaturalNumbers(numBeg, constant);
Console.WriteLine();