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


double[] GetArray(int size, double minVal, double maxVal)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (maxVal - minVal) + minVal;
        result[i] = Math.Round(num, 1);
    }
    return result;
}


int FindMax(double[] array)
{
    int imax = 0, size = array.Length;
    for(int i = 0; i < size; i++)
    {
        if(array[i] > array[imax]) imax = i;
    }
    return imax;
}


int FindMin(double[] array)
{
    int imin = 0, size = array.Length;
    for(int i = 0; i < size; i++)
    {
        if(array[i] < array[imin]) imin = i;
    }
    return imin;
}


double[] arr = GetArray(10, -100, 100);
PrintArray(arr);
int maxIndex = FindMax(arr);
int minIndex = FindMin(arr);
double diff = arr[maxIndex] - arr[minIndex];
diff = Math.Round(diff, 1);
Console.WriteLine($"Difference between max and min is {diff}");