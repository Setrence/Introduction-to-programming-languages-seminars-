Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int lastNumber = number % 10;
    Console.WriteLine("Последняя цифра вашего числа: " + lastNumber);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}