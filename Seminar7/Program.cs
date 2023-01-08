// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.
// // m = 3, n = 4.
// // 0,5 7,0 -2,0 -0,2
// // 1,0 -3,3 8,0 -9,9
// // 8,0 7,8 -7,1 9,0

// Console.Clear();
// Console.WriteLine($"Set a two-dimensional array m x n, filled with random real numbers: ");

// Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];

// CreateArrayDouble(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array)
// {
// for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }


// // Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве 
// // или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.Write("Enter string: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Enter column: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; 
// int m = 7; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Original array: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);
//         Console.Write("{0} ", arr[i, j]);
//     }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Element does not exist");
// }
//     else
// {
//     Console.WriteLine("Array element value = {0}", arr[pos1, pos2]);
// }

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// Console.WriteLine("This program calculates the average of each column.");
// Console.WriteLine();
// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("_________________");
// Console.WriteLine();


// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             sum += arr[i, j];
//         }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.WriteLine();