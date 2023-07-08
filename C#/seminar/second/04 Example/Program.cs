Console.Write("Введите число... ");
int number = int.Parse(Console.ReadLine());
int first_divin = number % 7;
int second_divin = number % 23;

if (first_divin == 0 && second_divin == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23");
}