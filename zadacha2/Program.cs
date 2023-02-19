Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number22 = Convert.ToInt32(Console.ReadLine());

if (number1 > number22)
{
    Console.WriteLine($"maxnumber = {number1}" ); 
    Console.WriteLine($"minnumber = {number22}" );
}
else if (number22 > number1)
{
    Console.WriteLine($"maxnumber = {number22} " );
    Console.WriteLine($"minnumber = {number1} " );
}