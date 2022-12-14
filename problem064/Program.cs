void PrintNumbers(int num)
{
    if(num == 1)
    {
        Console.WriteLine($"{num}");
    }
    else
    {
        Console.Write($"{num}, ");
        PrintNumbers(num - 1);
    }
}


Console.Write("Enter number N --> ");
int N = Convert.ToInt32(Console.ReadLine());
if(N > 0) PrintNumbers(N);
else Console.WriteLine("Your number has to be more than 0");