int[] array_numbers = {11, 21, 31, 41, 15, 61, 17, 18, 19};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = Max(Max(array_numbers[0], array_numbers[1], array_numbers[2]),
          Max(array_numbers[3], array_numbers[4], array_numbers[5]),
          Max(array_numbers[6], array_numbers[7], array_numbers[8]));

Console.WriteLine(max);