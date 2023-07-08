Console.Write("Введите трёхзначное число... ");
int number = int.Parse(Console.ReadLine());

int s_number = number / 10 % 10;

Console.WriteLine($"Вторая цифра числа {number} равна {s_number}");