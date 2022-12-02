void PrintArray(double[] array)
{
    int size = array.Length;
    Console.Write("[");
    for(int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[size-1]}]");
}


int[,] GetMatrixRndInt(int rows, int cols, int minVal, int maxVal)
{
    int[,] result = new int[rows,cols];
    Random rnd = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            result[i,j] = rnd.Next(minVal, maxVal + 1);
        }
    }
    return result;
}


void PrintMatrixInt(int[,] matrix)
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


double[] GetMediumsOfCols(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[] result = new double[cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            result[j] += matrix[i,j];
        }
    }

    for(int i = 0; i < cols; i++)
    {
        result[i] /= rows;
        result[i] = Math.Round(result[i], 2);
    }

    return result;
}


int[,] matr = GetMatrixRndInt(6, 7, 0, 9);
PrintMatrixInt(matr);
double[] mediums = GetMediumsOfCols(matr);
PrintArray(mediums);