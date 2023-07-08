// Console.Write("Введите первое число... ");
// int first_number = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число... ");
// int second_number = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число... ");
// int third_number = int.Parse(Console.ReadLine());

// if (first_number > second_number)
// {
//     if (first_number > third_number)
//     {
//         Console.WriteLine($"{first_number} максимальное число");
//     }
//     else
//     {
//         Console.WriteLine($"{third_number} максимальное число");
//     }
// }
// else if (first_number < second_number)
// {
//     if (second_number > third_number)
//     {
//         Console.WriteLine($"{second_number} максимальное число");
//     }
//     else
//     {
//         Console.WriteLine($"{third_number} максимальное число");
//     }
// }
// OR

int[] array_numbers = new int[3];

Console.Write("Введите первое число... ");
array_numbers[0] = int.Parse(Console.ReadLine());

Console.Write("Введите второе число... ");
array_numbers[1] = int.Parse(Console.ReadLine());

Console.Write("Введите третье число... ");
array_numbers[2] = int.Parse(Console.ReadLine());

int max_number = array_numbers[0];

for (int i = 0; i < array_numbers.Length; i++)
{
    if (max_number < array_numbers[i]) max_number = array_numbers[i];
}
Console.WriteLine($"{max_number} максимальное число");