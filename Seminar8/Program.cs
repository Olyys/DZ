// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// // элементы каждой строки двумерного массива.

// void PrintArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(0,100);
//         }
//     }
// }

// void SelectionSort(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(1)-1; k++) 
//             {
//                 if (matr[i,k] < matr[i, k + 1])
//                 {
//                     int temporary = matr[i, k + 1];
//                     matr[i, k + 1] = matr[i, k];
//                     matr[i,k] = temporary;
//                 }
//             }
            
//         }
//     }
// }

// int [, ] matrix = new int [5, 5];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// SelectionSort(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// // наименьшей суммой элементов.
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 100);
//         }
//     }
// }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[5, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// int minSumLine = 0;
// int sumLine = SumLineElements(matrix, 0);
// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//     int tempSumLine = SumLineElements(matrix, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }

// Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] matrix, int i)
// {
//     int sumLine = matrix[i,0];
//     for (int j = 1; j < matrix.GetLength(1); j++)
//     {
//         sumLine = sumLine + matrix[i,j];
//     }
//     return sumLine;
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }



// // Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу,
// //  которая будет находить произведение двух массивов (поэлементное).

// void PrintArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// int [, ] matrix1 = new int [2, 2];
// int [, ] matrix2 = new int [2, 2];
// int [, ] matrix3Result = new int [2, 2];

// FillArray(matrix1);
// Console.WriteLine();
// PrintArray(matrix1);
// Console.WriteLine();

// FillArray(matrix2);
// Console.WriteLine();
// PrintArray(matrix2);
// Console.WriteLine();

// void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3Result)
// {
//     for (int i = 0; i < matrix3Result.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3Result.GetLength(1); j++)
//         {
//            int multiply = 0;
//            for (int k = 0; k < matrix1.GetLength(1); k++)
//            {   
//               multiply = matrix1[i,j] * matrix2[i,j];
//            }
//            matrix3Result[i,j] = multiply;
//         }
//     }
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// MultiplyMatrix(matrix1, matrix2, matrix3Result);
// Console.WriteLine($"\nПроизведение первого и второго массива:");
// PrintArray(matrix3Result);


// // Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая 
// // будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void CreateArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {   
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }