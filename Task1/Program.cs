//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a==b*b)
{
    Console.Write ("Перое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}