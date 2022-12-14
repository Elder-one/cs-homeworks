//  Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит
//  число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

int Power(int number, int power)
{
    int result = 1;
    for(int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}


Console.Write("Enter an integer --> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the power more than 0 --> ");
int pow = Convert.ToInt32(Console.ReadLine());

if(pow > 0)
{
    int result = Power(num, pow);
    Console.WriteLine($"{num}**{pow} = {result}");
}
else Console.WriteLine("Your power is out of range");