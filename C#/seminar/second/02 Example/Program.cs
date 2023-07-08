int number = new Random().Next(100, 1000);

// int first_number = number / 100;
// int third_numbers = number % 10;
// Console.WriteLine($"Число {number} без средней цифры равно {first_number}{third_numbers}");

// OR

int first_number = number / 100 * 10;
int third_numbers = number % 10;
int result = first_number + third_numbers;
Console.WriteLine($"Число {number} без средней цифры равно {result}");