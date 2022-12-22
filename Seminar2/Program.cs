// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// // вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = a / 10 % 10;
// Console.WriteLine(b);

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// // третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.Write("Введите трехзначное число: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = a % 10;
// if ( a/10 > 10  )
// {
//     Console.Write("Третье число: ");
//     Console.WriteLine(b);
// }
// else {
//     Console.WriteLine("Третьего числа нет");
//  }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("нет");
}

if(day == b)
{
    Console.WriteLine ("нет");
}

if(day == c)
{
    Console.WriteLine ("нет");
}

if(day == d)
{
    Console.WriteLine ("нет");
}

if(day == e)
{
    Console.WriteLine ("нет");
}

if(day == f)
{
    Console.WriteLine ("да");
}

if(day == g)
{
    Console.WriteLine ("да");
}
