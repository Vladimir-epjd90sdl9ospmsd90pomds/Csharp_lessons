// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int[,] GenArrow(int rowQuantity, int colQuentity)
{
    int[,] tempArrow = new int[rowQuantity, colQuentity];
    for (int i = 0; i < tempArrow.GetLength(0); i++)
    {
        for (int j = 0; j < tempArrow.GetLength(1); j++)
        {
            tempArrow[i, j] = new Random().Next(0, 15);
        }
    }
    return tempArrow;
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

int[] RightMatrixComb()
{
    int[] tempMatrixParam = new int[4];
    Console.WriteLine("Введите кол-во строк 1-ой матрицы:");
    int rows1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов 1-ой матрицы:");
    int columns1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк 2-ой матрицы:");
    int rows2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов 2-ой матрицы:");
    int columns2 = Convert.ToInt32(Console.ReadLine());
    if (rows2 == columns1)
    {
        tempMatrixParam[0] = rows1;
        tempMatrixParam[1] = columns1;
        tempMatrixParam[2] = rows2;
        tempMatrixParam[3] = columns2;
        return tempMatrixParam;

    }
    else
    {
        Console.WriteLine("Количество столбцов 1й матрицы равно кол-ву строк 2й матрицы:");
        return RightMatrixComb();
    }
}

void Print1D(int[] printingArray)
{
    foreach (int item in printingArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] multiArr)
{
    int tempNum = 0;
    for (int i = 0; i < multiArr.GetLength(0); i++)
    {
        for (int j = 0; j < multiArr.GetLength(1); j++)
        {
            for (int l = 0; l < array1.GetLength(1); l++)
            {
                tempNum += array1[i, l] * array2[l, j];
            }
            multiArr[i, j] = tempNum;
            tempNum = 0;
        }
    }
}


int[] rightTables = RightMatrixComb();
int[,] multiArray = new int[rightTables[0], rightTables[3]];
int[,] resultArray1 = GenArrow(rightTables[0], rightTables[1]);
int[,] resultArray2 = GenArrow(rightTables[2], rightTables[3]);
Print2D(resultArray1);
Print2D(resultArray2);
MultiplyMatrix(resultArray1, resultArray2, multiArray);
Print2D(multiArray);
