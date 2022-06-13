Console.WriteLine("Введите координату x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distant = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
Console.WriteLine(Math.Sqrt(distant));