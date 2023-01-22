/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Введите первое число:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.WriteLine("Введите третье число:");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);

int max = a;
if (b > a)
{
   max = b;
}
if (c > b)
{
    max = c;
}

else
{
    Console.WriteLine ("Все числа равны");
}

Console.WriteLine($"Максимальное число: {max}");