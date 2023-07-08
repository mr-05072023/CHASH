Console.Write("Введите трёхзначное число... ");
int number = int.Parse(Console.ReadLine());
int last_number = number % 10;
Console.WriteLine($"Последняя цифра числа {number} равна {last_number}");