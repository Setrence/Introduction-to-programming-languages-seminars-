// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите элементы массива:");
int[] array = new int[8];

for (int i = 0; array.Length > i; i++)
{
    array [i] = Convert.ToInt32(Console.ReadLine());
}


void Metod(int[] array)
{
    Console.Write("Вывод массива: ");
    for (int i = 0; array.Length - 1 > i; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

Metod(array);