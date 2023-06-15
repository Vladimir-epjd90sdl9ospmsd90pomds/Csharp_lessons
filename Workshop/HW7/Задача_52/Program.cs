// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Gen2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 30);
        }
    }
}

void Print2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine("");
    }
}

void CheckMidleSum(int[,] arr)
{
    decimal sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        Console.Write($"{Math.Round((decimal)(sum / arr.GetLength(0)), 1)}; ");
        sum = 0;
    }
}


Console.WriteLine("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество колонок: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] geningArray = new int[row, col];

Gen2DArray(geningArray);
Print2D(geningArray);
CheckMidleSum(geningArray);