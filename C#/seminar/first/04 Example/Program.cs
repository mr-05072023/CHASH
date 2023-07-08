Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    int count = number * -1;
    while (number >= count)
    {
        Console.Write(count + " ");
        count++;
    }
    Console.WriteLine();
}
else if (number < 0)
{
    int count = number * -1;
    while (count >= number)
    {
        Console.Write(count + " ");
        count--;
    }
    Console.WriteLine();
}
else
{
    Console.Write($"{number} \n");
}