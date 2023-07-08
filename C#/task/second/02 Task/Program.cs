Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());

if (number > 99) 
{
    while (number > 1000)
    {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine($"Третья цифра равна {number}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}