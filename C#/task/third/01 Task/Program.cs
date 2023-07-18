void ItISPalindrome(int number)
{
    int j = 1;
    for (int i = 4; i >= 0; i--)
    {
        int firstNumber = (int) (number / (Math.Pow(10, i))) % 10;
        int secondNumber = number % (int) Math.Pow(10, j) / (int) Math.Pow(10, j - 1);
        j++;
        if (firstNumber != secondNumber)
        {
            Console.WriteLine("Число не палиндром");
            break;
        }
        if (i == 0)
        {
            Console.WriteLine("Число палиндром");
        }
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
ItISPalindrome(GetInfo("Введите пятизначное число... "));