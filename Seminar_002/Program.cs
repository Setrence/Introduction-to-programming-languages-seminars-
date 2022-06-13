Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("По х: от 0 до + бесконечности");
    Console.WriteLine("По y: от 0 до + бесконечности");
}
if (number == 2)
{
    Console.WriteLine("По х: от - бесконечности до 0");
    Console.WriteLine("По y: от 0 до + бесконечности");
}
if (number == 3)
{
    Console.WriteLine("По х: от - бесконечности до 0");
    Console.WriteLine("По y: от - бесконечности до 0");
}
if (number == 4)
{
    Console.WriteLine("По х: от 0 до бесконечности");
    Console.WriteLine("По y: от - бесконечности до 0");
}
