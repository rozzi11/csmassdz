// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int m = 3, n = 4;
//         Random rnd = new Random();
//         double[,] arr = new double[m, n];

//         for(int i = 0; i < m; i++)
//         {
//             for(int j = 0; j < n; j++)
//             {
//                 arr[i, j] = rnd.NextDouble() * 20 - 10;
//             }
//         }

//         // вывод массива на экран
//         for(int i = 0; i < m; i++)
//         {
//             for(int j = 0; j < n; j++)
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, 
//                                        { 5, 9, 2, 3 }, 
//                                        { 8, 4, 2, 4 } };

//         Console.Write("Введите номер строки: ");
//         int row = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int column = Convert.ToInt32(Console.ReadLine());

//         if (row >= array.GetLength(0) || column >= array.GetLength(1))
//         {
//             Console.WriteLine("Ошибка: такого элемента в массиве нет.");
//         }
//         else
//         {
//             int value = array[row, column];
//             Console.WriteLine($"Значение элемента: {value}");
//         }

//         Console.ReadLine();
//     }
// }

// int[,] array = new int[,]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// int rows = array.GetLength(0);
// int cols = array.GetLength(1);

// double[] averages = new double[cols]; 

// for (int j = 0; j < cols; j++)
// {
//     int sum = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         sum += array[i, j]; 
//     }
//     averages[j] = (double)sum / rows; 
// }


// for (int j = 0; j < cols; j++)
// {
//     Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {averages[j]}");
// }