// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.WriteLine($"День недели: {Metod(number)}");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}


string Metod (int number)
{
    if (number == 6)
    {
        return ("Выходной");
    }
    if (number == 7)
    {
        return ("Выходной");
    }
    else
    {
        return ("Рабочий");
    }
}