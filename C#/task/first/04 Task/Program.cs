Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}");
        if (!(i + 1 == number || i == number)) Console.Write(", ");
    }
}
Console.Write("\n");
