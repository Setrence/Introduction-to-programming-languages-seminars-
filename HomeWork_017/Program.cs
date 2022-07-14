//Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите число через запятую: ");
string[] a = Console.ReadLine().Split(",");
int[] b = Converter(a);
int counter = Count(b);

Console.WriteLine(counter);

static int Count(int[] array)
{
    int returnCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            returnCounter ++;
        }
    }

    return returnCounter;
}

static int[] Converter(string[] array)
{
    int[] returnArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       returnArray[i] = Convert.ToInt32(array[i]);
    }

    return returnArray;
}