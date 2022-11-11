// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter two integers --> ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2*number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}