/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("ВВедите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 2; i <= number; i = i +2)
{
     Console.Write(i + ",");
}
