// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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


int GetOddElementsSum(int[] array)
{
    int size = array.Length, sum = 0;
    for(int i = 0; i < size; i++)
    {
        if(i % 2 == 1) sum += array[i];
    }
    return sum;
}


int[] arr = GetArray(8, -100, 100);
PrintArray(arr);
int oddElementsSum = GetOddElementsSum(arr);
Console.WriteLine($"Sum of the odd elements = {oddElementsSum}");
