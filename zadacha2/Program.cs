Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxnumber = -1;
int minnumber = -1;
if (number1 > maxnumber)
{
    maxnumber = number1;
}
else if (number2 > maxnumber)
{
    maxnumber = number2;
    maxnumber = number1;
}
else maxnumber = number1;
     minnumber = number2;

Console.Write(maxnumber);
Console.Write(minnumber);


