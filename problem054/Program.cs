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


void SortArray(int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size - 1; i++)
    {
        for(int j = 0; j < size-i-1; j++)
        {
            if(array[j] < array[j+1])
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
}


void SortMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    for(int i = 0; i < rows; i++)
    {
        int[] tempRow = GetRowFromMatrix(matrix, i);
        SortArray(tempRow);
        InsertRowInMatrix(matrix, tempRow, i);
    }
}


int[,] matr = GetMatrixRndInt(5, 7, -9, 9);
PrintMatrixInt(matr);
SortMatrix(matr);
PrintMatrixInt(matr);