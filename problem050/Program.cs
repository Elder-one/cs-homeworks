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


bool CheckIfPositionExists(int i, int j, double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    if(i >= 0 && i < rows)
    {
        if(j >= 0 && j < cols)
        {
            return true;
        }
    }
    return false;
}


double[,] matr = GetMatrixRndDouble(5, 6, -20, 20);
PrintMatrixDouble(matr);

int row = GetInt("Enter row --> ");
int col = GetInt("Enter collumn --> ");
if(CheckIfPositionExists(row, col, matr))
{
    Console.WriteLine($"{matr[row,col]}");
}
else Console.WriteLine("This position does not exist");
