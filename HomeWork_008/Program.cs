// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 999)
{
    int number2 = Metod(number) / 10;
    Console.WriteLine($"Вторая цифра числа {number} будет: {number2}");
}
else
{
    Console.WriteLine("Вы ввлели не трехзначное число");
}


int Metod(int number)
{
    return (number % 100);
}
