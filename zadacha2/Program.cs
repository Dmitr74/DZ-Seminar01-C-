Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"maxnumber = {number1}" ); 
    Console.WriteLine($"minnumber = {number2}" );
}
else if (number2 > number1)
{
    Console.WriteLine($"maxnumber = {number2} " );
    Console.WriteLine($"minnumber = {number1} " );
}