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


void InsertRowInMatrix(int[,] matrix,
                       int[] row,
                       int rowIndex)
{
    int cols = matrix.GetLength(1);
    for(int i = 0; i < cols; i++)
    {
        matrix[rowIndex, i] = row[i];
    }
}


void SwapRows(int[,] matrix, int index1, int index2)
{
    row1 = GetRowFromMatrix(matrix, index1);
    row2 = GetRowFromMatrix(matrix, index2);
    InsertRowInMatrix(matrix, row1, index2);
    InsertRowInMatrix(matrix, row2, index1);
}