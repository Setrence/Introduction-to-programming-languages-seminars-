//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2//

int [] array = new int [4];
int sumEven = 0;

for (int i=0; i< array.Length; i++)
{
    array[i] = new Random(). Next(100, 1000);
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
    if(array[i] % 2 == 0)
        sumEven = sumEven + 0;
    else 
        sumEven = sumEven + 1;    
}
Console.WriteLine($"Четных чисел в массиве = {sumEven}");