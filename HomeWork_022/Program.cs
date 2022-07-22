//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumber(numberN);

void NaturalNumber(int numberN)
{
    if (numberN == 1)
    {
        Console.WriteLine(numberN);
    }
    if (numberN > 1)
    {
        Console.Write($"{numberN}, ");
        NaturalNumber(numberN - 1);
    }    
    if (numberN < 1)
    {
        Console.Write($"{numberN}, ");
        NaturalNumber(numberN + 1); 
    }

}