int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;


for (int i=0; i< array.Length; i++)
{
    array[i] = new Random(). Next(-9, 10);
}

void PrintArray(int[] array)
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);

for (int i=0; i< array.Length; i++)
{
    if(array[i] > 0)
        sumPositive += array[i];
    else 
        sumNegative += array[i];    
}
Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");