// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] GenArrow(int rowQuantity, int colQuentity)
{
    int[,] tempArrow = new int[rowQuantity, colQuentity];
    for (int i = 0; i < tempArrow.GetLength(0); i++)
    {
        for (int j = 0; j < tempArrow.GetLength(1); j++)
        {
            tempArrow[i, j] = new Random().Next(0, 64);
        }
    }
    return tempArrow;
}

void ArrowSorting(int[,] arrForScan)
{
    int temp = 0;
    for (int i = 0; i < arrForScan.GetLength(0); i++)
    {
        for (int j = 0; j < arrForScan.GetLength(1); j++)
        {
            for (int k = j + 1; k < arrForScan.GetLength(1); k++)
            {
                if (arrForScan[i, k] > arrForScan[i, j])
                {
                    temp = arrForScan[i, j];
                    arrForScan[i, j] = arrForScan[i, k];
                    arrForScan[i, k] = temp;
                }
            }
        }
    }
}

void Print2D(int[,] printingArray)
{
    for (int i = 0; i < printingArray.GetLength(0); i++)
    {
        for (int j = 0; j < printingArray.GetLength(1); j++)
        {
            Console.Write($"{printingArray[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Введите кол-во строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultArrow = GenArrow(rows, columns);
Print2D(resultArrow);
ArrowSorting(resultArrow);
Print2D(resultArrow);