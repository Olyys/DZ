// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// // является ли оно палиндромом. (читается слева направо и справа налево одинаково)
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//  if (number[0] == number[4] && number[1] == number[3])
//     {
//  Console.WriteLine($"{number} - Палиндром");
//     }
//  else
//     {
//  Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//  Console.WriteLine($"FATAL: {number} - не является пятизначным");
// }

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// // ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите перую координату точки 1: ");
// double a = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите вторую координату точки 1: ");
// double b = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите третью координату точки 1: ");
// double z = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите перую координату точки 2: ");
// double a1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите вторую координату точки 2: ");
// double b1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите третью координату точки 2: ");
// double z1 = double.Parse(Console.ReadLine());


// double ab = Math.Sqrt(Math.Pow(a-a1, 2) + Math.Pow(b - b1, 2)+Math.Pow(z-z1, 2));

// Console.WriteLine(ab);

// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;

// while (i<=N)
// {
// Console.Write(" " + i*i*i);
// i++;
// }
