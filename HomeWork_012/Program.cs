// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Metod(int number)
{
    int A = 0;
    int B = 0;

    for (int i = 0; number > i; i++)
    {
        A = number % 10;
        B = B + A;
        number = number / 10;
    }
    return (B);
}

int result = Metod(number);
Console.WriteLine($"Ответ: {result}");