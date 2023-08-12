int GetSumOfSequenceNumbers(int M, int N)
{
    if (M != N + 1) return M + GetSumOfSequenceNumbers(M + 1, N);
    return 0;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int M = GetInfo("Введите начало последовательности... ");
int N = GetInfo("Введите окончание последовательности... ");
Console.WriteLine($"Сумма чисел последовательности от {M} до {N} = {GetSumOfSequenceNumbers(M, N)}");