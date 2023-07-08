Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} чётное");
}
else
{
    Console.WriteLine($"Число {number} нечётное");
}
