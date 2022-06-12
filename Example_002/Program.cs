Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
    Console.WriteLine(number1 + "^2" + "=" + number2 + " (True) ");
else
    Console.WriteLine(number1 + "^2" + "=" + number2 + " (False) ");