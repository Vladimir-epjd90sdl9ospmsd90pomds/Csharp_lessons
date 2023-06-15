// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

decimal[,] Gen2DArray(int str, int col)
{
    decimal[,] geningArray = new decimal[str, col];
    for (int i = 0; i < geningArray.GetLength(0); i++)
    {
        for (int j = 0; j < geningArray.GetLength(1); j++)
        {
            geningArray[i, j] = ((decimal)(new Random().Next(-500, 500))) / 10;
        }
    }
    return geningArray;
}

void Print2D(decimal[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество колонок: ");
int col = Convert.ToInt32(Console.ReadLine());

Print2D(Gen2DArray(row, col));