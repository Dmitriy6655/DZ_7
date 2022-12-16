// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными  числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1  9

using static Common.Helper;

Console.Write("enter the size line (m): ");
int line = int.Parse(Console.ReadLine());
Console.Write("enter the size column (n): ");
int column = int.Parse(Console.ReadLine());

double[,] array = new double[line, column];
double[,] arrayResult = RandomArrayDouble(array);
PrintResultDouble(arrayResult);
