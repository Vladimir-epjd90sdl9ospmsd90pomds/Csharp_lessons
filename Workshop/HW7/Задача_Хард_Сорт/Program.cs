// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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
            for (int k = i; k < arrForScan.GetLength(0); k++)
            {
                if (k == i)
                {
                    for (int l = j; l < arrForScan.GetLength(1); l++)
                    {
                        if (arrForScan[k, l] < arrForScan[i, j])
                        {
                            temp = arrForScan[k, l];
                            arrForScan[k, l] = arrForScan[i, j];
                            arrForScan[i, j] = temp;
                        }
                    }
                }
                else if (k != i)
                {
                    for (int l = 0; l < arrForScan.GetLength(1); l++)
                    {
                        if (arrForScan[k, l] < arrForScan[i, j])
                        {
                            temp = arrForScan[k, l];
                            arrForScan[k, l] = arrForScan[i, j];
                            arrForScan[i, j] = temp;
                        }
                    }
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