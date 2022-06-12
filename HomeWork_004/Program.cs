// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.Write("Четные числа:");
while (i <= numberN)
{
    if (i % 2 > 0)
    {
        Console.Write(" ");
    }
    else
    {
        Console.Write(i);
    }
    i++;
}