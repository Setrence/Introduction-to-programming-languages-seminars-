// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;

if (number > 100)
{
    int number3 = Metod(number, number2);
    Console.WriteLine($"Третья цифра числа будет {number3}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


int Metod(int number, int number2)
{
   while (number > 999)
   {
        number2 = number / 10;
        number = number2;
   }
    return (number % 10);
}
