int GetInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int Ackerman(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ackerman(m-1, 1);
    return Ackerman(m-1, Ackerman(m, n-1));
}


int M = GetInt("Enter M --> ");
int N = GetInt("Enter N --> ");
if(M >= 0 && N >= 0)
{
    Console.WriteLine($"{Ackerman(M, N)}");
}
else Console.WriteLine("Both numbers must be non-negative");