//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int [6];
int sumOddNumber = 0;

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

for (int i=0; i< array.Length; i++)
{
    if(i % 2 == 0)
        sumOddNumber = sumOddNumber + 0;
    else 
        sumOddNumber = sumOddNumber + array[i];    
}
Console.WriteLine($"Сумма элементов массива на нечетных позициях = {sumOddNumber}");