// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetDigitsSum(int number)
{
    number = Math.Abs(number);
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}


Console.Write("Enter an integer --> ");
int num = Convert.ToInt32(Console.ReadLine());

int digitsSum = GetDigitsSum(num);
Console.WriteLine($"Sum of the digits = {digitsSum}");