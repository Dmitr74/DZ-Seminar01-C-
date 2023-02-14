Console.Clear.
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > max)
{
    max = number1;
}
else if (number2 > max)
{
    max = number2,
    min = number1;
}
else max = number1, min = number2;

Console.Write("max ");
Console.Write("min ");


