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
            if(j < cols-1) Console.Write($"{matrix[i,j], 4} ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------");
}


int[] GetRowFromMatrix(int[,] matrix, int rowIndex)
{
    int cols = matrix.GetLength(1);
    int[] row = new int[cols];
    for(int i = 0; i < cols; i++)
    {
        row[i] = matrix[rowIndex, i];
    }
    return row;
}


int Sum(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        sum += array[i];
    }
    return sum;
}


int FindMinRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int imin = 0;
    int[] row = GetRowFromMatrix(matrix, 0);
    int minSum = Sum(row);
    for(int i = 0; i < rows; i++)
    {
        int[] currentRow = GetRowFromMatrix(matrix, i);
        int sum = Sum(currentRow);
        if(sum < minSum)
        {
            minSum = sum;
            imin = i;
        }
    }
    return imin;
}


int[,] matr = GetMatrixRndInt(5, 6, -20, 20);
PrintMatrixInt(matr);
int minRowPosition = FindMinRow(matr) + 1;
Console.WriteLine($"Row {minRowPosition} has the minimum sum of the elements");