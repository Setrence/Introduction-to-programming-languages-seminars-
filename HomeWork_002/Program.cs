// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Максистальное число: " + numberA);
}
else if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine("Максистальное число: " + numberB);
}
else if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine("Максистальное число: " + numberC);
}
else if (numberA > numberB && numberA == numberC)
{
    Console.WriteLine("Максистальное число: " + numberA);
}
else if (numberB > numberA && numberB == numberC)
{
    Console.WriteLine("Максистальное число: " + numberB);
}
else
{
    Console.WriteLine("Максистальное число: " + numberB);
}