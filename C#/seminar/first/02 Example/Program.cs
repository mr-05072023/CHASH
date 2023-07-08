Console.WriteLine("Введите два числа... ");
int first_number = int.Parse(Console.ReadLine());
int second_number = int.Parse(Console.ReadLine());

int first_square = first_number* first_number;
int second_square = second_number* second_number;

if (first_number == second_square)
{
    Console.WriteLine($"{first_number} является квадратом числа {second_number}");
}
else if (second_number == first_square) 
{
    Console.WriteLine($"{second_number} является квадратом числа {first_number}");
}
else
{
    Console.WriteLine($"Нет чисел сответствующих условиям задания");
}