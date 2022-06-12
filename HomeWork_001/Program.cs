// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Write("введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Максистальное число: " + numberA);
    Console.WriteLine("Минимальное число: " + numberB);
}
else
{
    Console.WriteLine("Максистальное число: " + numberB);
    Console.WriteLine("Минимальное число: " + numberA);
}
