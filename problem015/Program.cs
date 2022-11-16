/*  Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
Console.Write("Enter a number in range [1, 7] --> ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 1 && num <= 7)
{
    if(num > 5) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
else Console.WriteLine("Your number is out of range");
