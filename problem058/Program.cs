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
            if(j < cols-1) Console.Write($"{matrix[i,j], 5} ");
            else Console.Write($"{matrix[i,j], 5}");
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


int[] GetColFromMatrix(int[,] matrix, int colIndex)
{
    int rows = matrix.GetLength(0);
    int[] col = new int[rows];
    for(int i = 0; i < rows; i++)
    {
        col[i] = matrix[i, colIndex];
    }
    return col;
}


int ProductOfLines(int[] line1, int[] line2)
{
    int result = 0;
    int size = line1.Length;
    for(int i = 0; i < size; i++)
    {
        result += line1[i]*line2[i];
    }
    return result;
}


int[,] ProductOfMatrixes(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int cols = matrix2.GetLength(1);
    int[,] result = new int[rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            int[] row = GetRowFromMatrix(matrix1, i);
            int[] col = GetColFromMatrix(matrix2, j);
            result[i, j] = ProductOfLines(row, col);
        }
    }
    return result;
}


bool MatrixesCanProduct(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix2.GetLength(0);
    int cols = matrix1.GetLength(1);
    if(rows == cols) return true;
    return false;
}


int[,] matr1 = GetMatrixRndInt(3, 4, 0, 9);
int[,] matr2 = GetMatrixRndInt(4, 5, 0, 9);
PrintMatrixInt(matr1);
PrintMatrixInt(matr2);

if(MatrixesCanProduct(matr1, matr2))
{
    Console.WriteLine("Here's your matrixes product");
    PrintMatrixInt(ProductOfMatrixes(matr1, matr2));
}
else Console.WriteLine("Matrixes cannot be producted");