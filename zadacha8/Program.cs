// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;

while (digit < number)
{
    digit = digit + 1;
    if (digit % 2 == 0)
    Console.Write($"{digit} ");

}
 System.Console.WriteLine("Чётных чисел больше нет.");