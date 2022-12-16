namespace Common;
public static class Helper
{
    //печать двумерного массива заполненного вещественными числами
    public static void PrintResultDouble(double[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("\t {0}", String.Join(" ", array[i, j]));
                //Console.Write($"{array[i,j]}  ");

            }
            Console.WriteLine();
        }

    }

    //генерация случайных чисел double
    public static double[,] RandomArrayDouble(double[,] array)
    {

        Random random = new Random();
        Random random2 = new Random();

        double num = 0;


        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {

                num = random.NextDouble() * 10;
                num = num * random2.Next(-2, 2);
                num = Math.Round(num, 1);
                array[i, j] = num;

            }
        }
        return array;
    }

    //генерация случайных чисел int
    public static int[,] RandomArrayInt(int[,] arrayInt)
    {

        Random random = new Random();

        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                arrayInt[i, j] = random.Next(0, 20); ;
            }
        }
        return arrayInt;
    }

    //печать двумерного массива с числами int
    public static void PrintResultArrayInt(int[,] arrayInt)
    {
        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                Console.Write("\t {0}", String.Join(" ", arrayInt[i, j]));
                //Console.Write($"{array[i,j]}  ");

            }
            Console.WriteLine();
        }

    }


    //печать строки с заменой последнего элемента на точку
    public static void PrintResultString(string resultString)
    {
        //ищем номер индекса последнего символа ";"
        int k = resultString.LastIndexOf(';');

        //удаляем 1 последний символ
        resultString = resultString.Remove(k, 1);

        //добавляем точку в последний индекс строки
        resultString = resultString.Insert(k, ".");

        Console.WriteLine("The arithmetic mean in each column of" +
        $"the array are equal:{resultString}");

    }

    //метод для нахождения среднего арифметического в каждом столбце 
    //двумерного массива
    public static string ArithmeticMeanColumn(int[,] arrayResult)
    {

        string result = String.Empty;
        double arithmeticMean = 0;
        //Console.Write($"тест {result}");
        int count = 0;
        var i = 0;

        while (count < arrayResult.GetLength(1))
        {
            for (i = 0; i < arrayResult.GetLength(0); i++)

            {
                arithmeticMean = (arithmeticMean + arrayResult[i, count]);

                if (i == arrayResult.GetLength(0) - 1)
                {
                    arithmeticMean = arithmeticMean / arrayResult.GetLength(0);
                    arithmeticMean = Math.Round(arithmeticMean, 1);
                    result = result + string.Format("  {0};", arithmeticMean);
                    //Console.WriteLine($"Result равно:{result}");
                    count++;
                    arithmeticMean = 0;
                }
            }

        }

        return result;
    }


    //печать индексов найденного в массиве числа
    public static void PrintResultIndexNumInArray(int number, string numberIndices, bool presenceNumber)
    {
        //int s = 0;

        if (presenceNumber == true)
        {
            int k = numberIndices.LastIndexOf(';');

            //удаляем 1 последний символ
            numberIndices = numberIndices.Remove(k, 1);

            //добавляем точку в последний индекс строки
            numberIndices = numberIndices.Insert(k, ".");

            Console.WriteLine($"The index of the found number <{number}> in the array is: {numberIndices}");
        }


        else
        {
            Console.WriteLine("The entered number is missing!");
        }
    }

    public static (string, bool) SearchIndexNumber(int N, int[,] arrayResult)
    {

        string result = String.Empty;
        bool statusNum = false;


        for (var i = 0; i < arrayResult.GetLength(0); i++)
        {
            for (var j = 0; j < arrayResult.GetLength(1); j++)
            {
                if (arrayResult[i, j] == N)
                {
                    statusNum = true;
                    //суммируем все строки с найденными индексами в одну строку
                    result = result + string.Format("\n {0}, {1} (line, column);", i, j);

                }


            }
        }

        return (result, statusNum);
    }


}
