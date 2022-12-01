void PrintArray(int[] array)
{
    int size = array.Length;
    Console.Write("[");
    for(int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[size-1]}]");
}


int[] InputArray()
{
    Console.Write("Input numbers count --> ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i+1} --> ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}


int CountPositive(int[] array)
{
    int size = array.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}


int[] arr = InputArray();
PrintArray(arr);
int countPositive = CountPositive(arr);
Console.WriteLine($"There are {countPositive} numbers more than 0");
