int GetInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


double[,] GetMatrixRndDouble(int rows, int cols, double minVal, double maxVal)
{
    double[,] result = new double[rows,cols];
    Random rnd = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            double num = rnd.NextDouble() * (maxVal - minVal) + minVal;
            result[i,j] = Math.Round(num, 1);
        }
    }
    return result;
}


void PrintMatrixDouble(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    Console.WriteLine("-------------------------");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            if(j < cols-1) Console.Write($"{matrix[i,j]} ");
            else Console.Write($"{matrix[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------");
}


int m = GetInt("Enter m --> ");
int n = GetInt("Enter n --> ");

double[,] matr = GetMatrixRndDouble(m, n, -100, 100);
PrintMatrixDouble(matr);