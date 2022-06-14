// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите число x: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число y: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int B = 0;

if (Metod(number1, number2, B) > 0)
{
    Console.WriteLine($"Число {Metod(number1, number2, B)} является вкадратом другого числа");    
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого");    
}



int Metod(int number1, int number2, int B)
{
    {
        if (number2 == (number1 * number1))
        {
            return (B = number2);
        }
        if (number1 == (number2 * number2))
        {
            return (B = number1);
        }
        else 
        {
            return (B = B);
        }
    }
}