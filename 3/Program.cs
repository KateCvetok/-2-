// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine ("введите значение четверти"); // 1 2 3 4
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Диапазон для возможных координат: x>0; y>0");
}
else if (a == 2)
{
    Console.WriteLine("Диапазон для возможных координат: x<0; y>0");
}
else if (a == 3)
{
    Console.WriteLine("Диапазон для возможных координат: x<0; y<0");
}
else 
{
    Console.WriteLine("Диапазон для возможных координат: x>0; y<0");
}