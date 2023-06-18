// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка



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

void FindingMinRow(int[,] arrForScan)
{

    int minSum = 0;
    int num = 0;
    for (int i = 0; i < arrForScan.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrForScan.GetLength(1); j++)
        {
            sum += arrForScan[i, j];
        }

        if (i == 0) minSum = sum;
        //Console.WriteLine(sum);

        if (sum < minSum)
        {
            minSum = sum;
            num = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:{num + 1}");


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
FindingMinRow(resultArrow);
