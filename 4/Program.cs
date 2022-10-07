// Найти расстояние между точками в пространстве 2D
double x1;
double x2;
double y1;
double y2;
double result;
Console.WriteLine ("введите координату х для первой точки");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите координату y для первой точки");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите координату х для второй точки");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("введите координату y для второй точки");
y2 = Convert.ToDouble(Console.ReadLine());
result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine ("Расстояние между точками в пространстве " +result);
