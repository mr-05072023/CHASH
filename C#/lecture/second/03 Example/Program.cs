int[] array_numbers = {1, 15, 31, 4, 15, 16, 17, 18};

int number = array_numbers.Length;
Console.Write("Введите число... ");
int find = int.Parse(Console.ReadLine());

int index = 0;

while (index < number)
{
    if (array_numbers[index] == find)
    {
        Console.WriteLine($"Индекс числа {find} равен {index}");
        break;
    }
    index++;
}
