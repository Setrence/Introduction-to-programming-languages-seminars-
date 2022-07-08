//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[4];
int max = 0;
int min = array[0];
int substr = 0;

for (int i=0; i< array.Length; i++)
{
    array[i] = new Random(). Next(-100 , 100);
}

PrintArray(array);

void PrintArray(int[] array)
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Max (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i]; 
        }
        else max = max;
    }
    Console.WriteLine($"max = {max}");
}

void Min (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (min >= array[i])
        {
            min = array[i]; 
        }
        else min = min;
    }
    Console.WriteLine($"min = {min}");
}

Max(array);
Min(array);

substr = max - min;
Console.WriteLine($"Разность = {substr}");