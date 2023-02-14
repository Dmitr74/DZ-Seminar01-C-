Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxnumber = number1;

if (number1 > number2)
{
    Console.Write(maxnumber = number1 ); 
    Console.Write(minnumber = number2 );
}
else if (number2 > number1)
{
    Console.Write(maxnumber = number2 );
    Console.Write(minnumber = number1 );
}