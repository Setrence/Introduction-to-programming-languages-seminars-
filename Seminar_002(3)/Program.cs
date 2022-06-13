Console.Write("Введите число: ");
int min = 1;
int N = Convert.ToInt32(Console.ReadLine());

while (N >= min)
{
    Console.WriteLine(Metod(min));
    min++;
}






int Metod (int N)
{
    return N*N;
}

