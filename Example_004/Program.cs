Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int min = -number;
while(min <= number)
{
    Console.Write(min + " ");
    min++;
}