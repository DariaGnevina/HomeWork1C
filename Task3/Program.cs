/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("ВВедите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if(number % 2 ==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
