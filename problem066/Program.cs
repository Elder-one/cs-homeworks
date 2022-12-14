int GetInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int FindSumBetween(int num1, int num2)
{
    if(num1 > num2) return num1 + FindSumBetween(num1 - 1, num2);
    if(num1 < num2) return num2 + FindSumBetween(num1, num2 - 1);
    return num1;
}


int M = GetInt("Enter M --> ");
int N = GetInt("Enter N --> ");
int sum = FindSumBetween(M, N);
Console.WriteLine($"Sum between {M} and {N} included is {sum}");