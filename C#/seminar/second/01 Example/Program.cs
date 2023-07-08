int random_number = new Random().Next(10, 100);
int first_value = random_number / 10;
int second_value = random_number % 10;
if (first_value > second_value)
{
    Console.WriteLine($"{first_value} максимальная цифра числа {random_number}");
}
else if (first_value < second_value)
{
    Console.WriteLine($"{second_value} максимальная цифра числа {random_number}");
}
else
{
    Console.WriteLine($"Цифры числа {random_number} равны");
}