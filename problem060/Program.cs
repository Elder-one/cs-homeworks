bool Matrix3DIsFillable(int[,,] matrix3d)
{
    int layers = matrix3d.GetLength(0);
    int rows = matrix3d.GetLength(1);
    int cols = matrix3d.GetLength(2);
    if(layers*rows*cols > 99 - 10 + 1) return false;
    return true;
}


void Fill3DMatrix(int[,,] matrix3d)
{
    int layers = matrix3d.GetLength(0);
    int rows = matrix3d.GetLength(1);
    int cols = matrix3d.GetLength(2);
    int count = 10;
    for(int i = 0; i < layers; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < cols; k++)
            {
                matrix3d[i,j,k] = count;
                count += 1;
            }
        }
    }
}


void Print3DMatrix(int[,,] matrix3d)
{
    int layers = matrix3d.GetLength(0);
    int rows = matrix3d.GetLength(1);
    int cols = matrix3d.GetLength(2);

    for(int i = 0; i < layers; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < cols; k++)
            {
                Console.Write($"{matrix3d[i, j, k]} ({i}, {j}, {k});   ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] matr3d = new int[3,4,10];
if(Matrix3DIsFillable(matr3d))
{
    Fill3DMatrix(matr3d);
    Print3DMatrix(matr3d);
}
else Console.WriteLine("Matrix cannot be filled with 2-digits numbers");