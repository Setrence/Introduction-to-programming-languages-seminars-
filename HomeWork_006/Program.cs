// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату x 1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x 2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y 1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y 2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z 1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z 2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distant = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
Console.WriteLine($"Ответ: {Math.Sqrt(distant)}");