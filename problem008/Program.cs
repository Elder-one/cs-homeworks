/*  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Enter a natural number N --> ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 1) Console.WriteLine("Out of range");
else if(num == 1) Console.WriteLine("Didn't find any even number in range [1, N]");
else
{
    int count = 2;
    while(count <= num)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
