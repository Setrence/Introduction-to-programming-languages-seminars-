//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double [4];
double max = 0;
double substr = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число:");
    array[i] = Convert.ToDouble(Console.ReadLine());
}

double min = array[0];

void Max (double[] array)
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

void Min (double[] array)
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