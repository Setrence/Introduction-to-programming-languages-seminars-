// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int min = 1;
int N = Convert.ToInt32(Console.ReadLine());

while (N > min)
{
    Console.Write($"{Metod(min)}, ");
    min++;
}

Console.Write(N*N*N);




int Metod (int N)
{
    return N*N*N;
}
