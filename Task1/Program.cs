/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */

Console.WriteLine("Введите первое число:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

if (a > b) 
{
    Console.WriteLine($"первое число {a} большее, а второе {b} меньшее");
}

if (a < b) 
{
    Console.WriteLine($"второе число {b} большее, а первое {a} меньшее");
}

else
{
    Console.WriteLine( "числа равны");
}