// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = RandomArray(m, n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} "); 
    }
    Console.WriteLine();
}

static double[,] RandomArray(int m, int n)
{
    Random rand = new Random();
    double[,] returnArray = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            returnArray[i,j] = Math.Round((rand.NextDouble() * 2 - 1) * 10, 1); 
        }
    }
    return returnArray;
} 