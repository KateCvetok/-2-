// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
if (b == a * a)
{
    Console.WriteLine("Второе число является квадратом первого числа");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого числа");
}