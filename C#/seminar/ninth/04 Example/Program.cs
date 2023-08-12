int GetExponentiation(int base_, int exponent)
{
    if (exponent != 0) return base_ * GetExponentiation(base_, exponent - 1);
    return 1;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int base_ = GetInfo("Введите основание числа... ");
int exponent = GetInfo("Введите основание числа... ");
Console.WriteLine($"Число {base_} возведённое в степень {exponent} = {GetExponentiation(base_, exponent)}");