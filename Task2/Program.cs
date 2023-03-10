// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

using static Common.Helper;

Console.Write("Enter the size line (m): ");
int line = int.Parse(Console.ReadLine());
Console.Write("Enter the size column (n): ");
int column = int.Parse(Console.ReadLine());



int[,] arrayInt = new int[line, column];

int[,] arrayResult = RandomArrayInt(arrayInt);

PrintResultArrayInt(arrayResult);

Console.Write("Enter any number: ");

bool num = int.TryParse(Console.ReadLine(), out int N);

//проверка ввода числа или другого символа
if (!num)
{
    Console.WriteLine("Value is not correct!");
}

//создаем заполненный массив

SearchIndexNumber(N, arrayResult);


//создаем новую строку с данными полученными от метода SearchIndexNumber

(string, bool) result2 = SearchIndexNumber(N, arrayResult);

//передаем переменную типа int(число N), 
//переменную типа string(result), переменную типа bool (statusNum)
// в метод PrintResult для вывода(печати) в консоль
PrintResultIndexNumInArray(N, result2.Item1, result2.Item2);

