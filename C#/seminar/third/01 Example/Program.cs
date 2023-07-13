﻿Console.WriteLine("Введите координаты точки...");
Console.Write("x = ");
int x = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка [{x}, {y}] находится в 1-ой четверти.");
}
if (x < 0 && y > 0)
{
    Console.WriteLine($"Точка [{x}, {y}] находится во 2-ой четверти.");
}
if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка [{x}, {y}] находится в 3-ей четверти.");
}
if (x > 0 && y < 0)
{
    Console.WriteLine($"Точка [{x}, {y}] находится в 4-ой четверти.");
}