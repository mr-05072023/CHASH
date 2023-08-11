void GetAndPrintTripleArray(int width, int height, int depth)
{
    int[,,] array = new int[width, height, depth];
    int min = 0;
    for (int i = 0; i < width; i++)
    {
        if (width * height * depth > 90)
        {
            Console.WriteLine("Слишком большой массив в для заполнения уникальными двузначными числами!");
            break;
        }
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                if (i == 0 && j == 0 && k ==0)
                { 
                    array[i, j, k] = 9;
                    min = array[i, j, k];
                }
                array[i, j, k] = 1 + min;
                min++;
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int width = GetInfo("Введите ширину массива... ");
int height = GetInfo("Введите высоту массива... ");
int depth = GetInfo("Введите глубину массива... ");
Console.WriteLine();
GetAndPrintTripleArray(width, height, depth);