Console.Write("Введите первое число... ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число... ");
int second_number = int.Parse(Console.ReadLine());
if (first_number > second_number) Console.WriteLine($"{first_number} больше чем {second_number}");
if (first_number < second_number) Console.WriteLine($"{second_number} больше чем {first_number}");