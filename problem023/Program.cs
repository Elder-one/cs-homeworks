void printSchedule(int N)
{
    if(N > 0)
    {
        for(int i = 1; i < N + 1; i++)
        {
            Console.WriteLine($"{i} | {i*i*i}");
        }
    }
    else Console.WriteLine("Your number is out of range");
}

Console.Write("Enter an integer more than 0 --> ");
int number = Convert.ToInt32(Console.ReadLine());

printSchedule(number);