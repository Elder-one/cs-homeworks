// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minVal, maxVal + 1);
    }
    return result;
}


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

int[] arr = GetArray(8, 1, 100);
PrintArray(arr);