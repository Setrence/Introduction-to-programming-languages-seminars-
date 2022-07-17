// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите строку");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int n1 = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int m2 = rand.Next(1,5);
int n2 = rand.Next(1,5);
double[,] array = RandomArray(m2, n2);
for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        Console.Write($"{array[i,j]} "); 
    }
    Console.WriteLine();
}
if(m1 < m2 && n1 < n2)
{
    Console.WriteLine($"Значение элемента массива: {array[m1,n1]}");
}
else
{
    Console.WriteLine("Элемент не существует");
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
