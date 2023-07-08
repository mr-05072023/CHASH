Console.Write("Введите первое число... ");
int first_number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число... ");
int second_number = int.Parse(Console.ReadLine());

Console.Write("Введите третье число... ");
int third_number = int.Parse(Console.ReadLine());

if (first_number > second_number)
{
    if (first_number > third_number)
    {
        Console.WriteLine($"{first_number} максимальное число");
    }
    else
    {
        Console.WriteLine($"{third_number} максимальное число");
    }
}
else if (first_number < second_number)
{
    if (second_number > third_number)
    {
        Console.WriteLine($"{second_number} максимальное число");
    }
    else
    {
        Console.WriteLine($"{third_number} максимальное число");
    }
}