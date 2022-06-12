// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 > 0)
{
    Console.WriteLine("Число " + numberA + " нечетное");
}
else
{
    Console.WriteLine("Число " + numberA + " четное");
}