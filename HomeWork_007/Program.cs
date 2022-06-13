// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int A = number % 10;
int B = number / 10000;
int C = number % 100;
C = C / 10;
int D = number / 1000;
D = D % 10;

if (Compare(A, B) == true && Compare(C, D) == true)
{
    Console.WriteLine($"{number} палиндром");
}
else
{
    Console.WriteLine($"{number} не палиндром");
}

bool Compare(int A, int B)
{
    if (A == B)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}