//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumNaturalNumber(numberN, numberM, sum);

void SumNaturalNumber(int numberN, int numberM, int sum)
{
    if (numberN < numberM)
    {
        Console.WriteLine(sum);
    }
    if (numberN >= numberM)
    {
        sum = sum + numberN;
        SumNaturalNumber(numberN - 1, numberM, sum);
    }    
  
}