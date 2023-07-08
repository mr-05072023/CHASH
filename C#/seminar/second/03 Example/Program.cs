Console.Write("Введите первое число... ");
int first_number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число... ");
int second_number = int.Parse(Console.ReadLine());

int digit = first_number % second_number;

if (digit == 0)
{
    Console.WriteLine($"Первое число {first_number} кратно второму числу {second_number}");
}
else
{
    Console.WriteLine($"Первое число {first_number} не кратно второму числу {second_number}, остаток равен {digit}");
}