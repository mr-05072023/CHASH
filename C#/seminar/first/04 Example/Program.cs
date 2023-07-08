Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (number >= count)
    {
        Console.Write(count + " ");
        count++;
    }
    // or
    // for (int count = -number; number >= count; count++)
    // {
    //     Console.Write(count + " ");
    // }
    Console.WriteLine();
}
else if (number < 0)
{
    int count = -number;
    while (count >= number)
    {
        Console.Write(count + " ");
        count--;
    }
    // or
    // for (int count = -number; count >= number; count--)
    // {
    //     Console.Write(count + " ");
    // }
    Console.WriteLine();
}
else
{
    Console.Write($"{number} \n");
}