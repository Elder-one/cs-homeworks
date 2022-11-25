// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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


int GetEvenCount(int[] array)
{
    int size = array.Length, count = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] % 2 == 0) count += 1;
    }
    return count;
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


int[] arr = GetArray(8, 100, 999);
PrintArray(arr);
int evenCount = GetEvenCount(arr);
Console.WriteLine($"There are {evenCount} even numbers in this array");

