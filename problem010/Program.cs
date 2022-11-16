/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1 */
Console.Write("Enter a 3-digit number --> ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if(num > 99 && num < 1000)
{
    int digit2 = num % 100 / 10;
    Console.WriteLine($"{digit2} is your second digit");
}
else Console.WriteLine("Your number is out of range");
