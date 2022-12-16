// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static Common.Helper;

Console.Write("Enter the size line (m): ");
int line = int.Parse(Console.ReadLine());
Console.Write("Enter the size column (n): ");
int column = int.Parse(Console.ReadLine());

int[,] arrayInt = new int[line, column];

//обращаемся к методу RandomArrayInt для заполнения двумерного массива
//случайными числами типа int
int[,] arrayResult = RandomArrayInt(arrayInt);

//печатаем заполненный массив 
PrintResultArrayInt(arrayResult);

//создаем новую строку и помещаем в нее то что вернул метод ArithmeticMeanColumn
string resultArithmeticMeanColumn = ArithmeticMeanColumn(arrayResult);

//вызываем метод печати строки
PrintResultString(resultArithmeticMeanColumn);





