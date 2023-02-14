Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > Max)
{
    Max = number1;
}
else if (number2 > Max)
{
    Max = number2;
    Max = number1;
}
else Max = number1;
     Min = number2;

Console.Write(Max);
Console.Write(Min);


