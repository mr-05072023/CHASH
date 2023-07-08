Console.Write("Введите первое число... ");
int f_number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число... ");
int s_number = int.Parse(Console.ReadLine());

bool SquareNumber(int f_number, int s_number)
{
    int f_square = f_number * f_number;
    int s_square = s_number * s_number;

    return f_square == s_number || s_square == f_number ? true : false;

}

if (SquareNumber(f_number, s_number))
{
    Console.WriteLine("Одно число является квадратом другого числа");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого числа");
}