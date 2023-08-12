int GetAckermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return GetAckermanFunction(M - 1, 1);
    if (M > 0 && N > 0) return GetAckermanFunction(M - 1, GetAckermanFunction(M, N - 1));
    return 1;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int M = GetInfo("Введите M... ");
int N = GetInfo("Введите N... ");
Console.WriteLine($"M = {M}, N = {N} -> A(M, N) = {GetAckermanFunction(M, N)}");