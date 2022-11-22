// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int GetNumberLength(int number)
{
    //Возвращает длину числа
    number = Math.Abs(number);
    int result = 0;
    while(number > 0)
    {
        number /= 10;
        result += 1;
    }
    if(result == 0) return 1; // значит ввели ноль
    return result;
}


int[] getArrayFromNumber(int number)
{
    // возвращает массив из цифр числа
    // в сортировке от младших к старшим
    int len = GetNumberLength(number);
    number = Math.Abs(number);
    int[] result = new int[len];
    int index = 0;

    while(index<len)
    {
        result[index] = number % 10;
        number /= 10;
        index += 1;
    }
    return result;
}


bool isPalindrome(int number)
{
    // Проверяет, является ли пятизначное число
    // палиндромом
    int[] array = getArrayFromNumber(number);
    if(array[0] != array[4]) return false;
    if(array[1] != array[3]) return false;
    return true;
}


Console.Write("Enter a 5-digit number --> ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if(num > 9999 && num < 100000) // Если число пятизначное
{
    if(isPalindrome(num)) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
else Console.WriteLine("Your number is out of range");
