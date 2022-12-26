// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // Не используя Math.Pow!
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B");
// int b = int.Parse(Console.ReadLine()!);
// int с = a;
// int i = 1;
// while (i < b)
// {
// с = с * a;
// i++;
// }
// Console.WriteLine("A в степени B равно: " + с);

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите число ");
// int number = int.Parse(Console.ReadLine()!);
// int len = NumberLen(number);
// SumNumbers(number, len);
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// // Задача 29: Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
// Console.Write("Введите любое число (A): ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];

// for (int i = 0; i < x; i++)
// {
//  array[i] = new Random().Next(x+1);
//  Console.Write(array[i] + "; ");
// }
// Console.WriteLine();