// Дано число, обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число, обозначающее день недели"); // 1 2 3 4 5 6 7
int a = int.Parse(Console.ReadLine());

if (a == 6)
{
    Console.WriteLine("Номер дня недели - выходной");
}
else if (a == 7)
{
    Console.WriteLine("Номер дня недели - выходной");
}
else
{
    Console.WriteLine("Номер дня недели - НЕ выходной");
}