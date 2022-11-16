 /* Напишите программу, которая выводит третью цифру заданного числа
  или сообщает, что третьей цифры нет. Выполнить с помощью
числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Write("Enter an integer (32bit) --> ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if(num > 99)
{
    while(num > 999)
    {
        num /= 10;
    }
    int digit3 = num % 10;
    Console.WriteLine($"{digit3} is your third digit");
}
else Console.WriteLine("There's no third digit in your number");