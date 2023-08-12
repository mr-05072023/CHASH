void GetReverseOrderOfNaturalNumbers(int temporary, int constant)
{
    if (temporary == constant) Console.Write($"\"");
    if (temporary != constant) GetReverseOrderOfNaturalNumbers(temporary + 1, constant);
    Console.Write($"{temporary}");
    if (temporary <= constant && temporary != 1) Console.Write($", ");
    if (temporary == 1) Console.Write($"\"");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numBeg = 1;
int constant = GetInfo("Введите конечное число последовательности натуральных чисел... ");
GetReverseOrderOfNaturalNumbers(numBeg, constant);
Console.WriteLine();