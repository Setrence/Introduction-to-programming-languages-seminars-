// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int number3 = numberA;

int Metod(int numberA, int numberB, int number3)
{
for (int i = 1; numberB > i; i++)
{
    number3 = number3 * numberA;
}
return (number3);
}

Console.WriteLine($"Ответ: {Metod(numberA, numberB, number3)}");