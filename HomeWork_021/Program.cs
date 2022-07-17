// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = 2;
int n = 2;
int[,] array = RandomArray(m, n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} "); 
    }
    Console.WriteLine();
}
Average(array, m, n);

static int[,] RandomArray(int m, int n)
{
    int[,] returnArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Позиция элемента ({i},{j}) Введите число: ");
            returnArray[i,j] = Convert.ToInt32(Console.ReadLine()); 
        }
    }
    return returnArray;
} 

static void Average(int[,] array, int m, int n)
{
    int average = 0;
    Console.Write("Среднее арифметическое элементов в каждом столбце: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            average += array[j, i];
        }
        Console.Write($"{average/m} ");
        average = 0;
    }
}
