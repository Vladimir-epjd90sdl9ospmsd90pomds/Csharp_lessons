// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Print2D(int[,] printingArray)
{
    for (int i = 0; i < printingArray.GetLength(0); i++)
    {
        for (int j = 0; j < printingArray.GetLength(1); j++)
        {
            Console.Write($"{printingArray[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MakeSnakeArray(int[,] arr2D)
{
    int tempRow = 0;
    int tempCol = 0;
    int num = 1;
    int length = arr2D.GetLength(1);
    int diff = 1;

    if (arr2D.GetLength(1) % 2 == 0)
    {
        for (int m = 0; m < length / 2; m++)
        {

            for (int i = 0; i < length - diff; i++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempCol++;
            }
            for (int j = 0; j < length - diff; j++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempRow++;
            }
            for (int k = 0; k < length - diff; k++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempCol--;
            }
            for (int l = 0; l < length - diff; l++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempRow--;
            }
            tempCol++;
            tempRow++;
            diff += 2;
        }
    }
    else
    {
        for (int m = 0; m < length / 2; m++)
        {

            for (int i = 0; i < length - diff; i++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempCol++;
            }
            for (int j = 0; j < length - diff; j++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempRow++;
            }
            for (int k = 0; k < length - diff; k++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempCol--;
            }
            for (int l = 0; l < length - diff; l++)
            {
                arr2D[tempRow, tempCol] = num;
                num++;
                tempRow--;
            }
            tempCol++;
            tempRow++;
            diff += 2;
        }

        arr2D[tempRow, tempCol] = num;
    }
}

//Console.WriteLine("Введите длину квадрата:");
int arr0 = 5; //Convert.ToInt32(Console.ReadLine());
int[,] arr2D = new int[arr0, arr0];
MakeSnakeArray(arr2D);
Print2D(arr2D);




// {
//     for (int j = tempCol; j < col - n; j++)
//     {
//         // if (j == tempCol)
//         // {
//         //     tempCol++;
//         //     continue;
//         // }
//         count++;
//         arr[i, j] = count;
//         Console.WriteLine($"i:{i},j:{j},count:{count}");
//         tempCol = j;
//     }
//     if (i == tempRow)
//     {
//         tempRow += 1;
//         continue;
//     }
//     count++;
//     arr[i, tempCol] = count;
//     Console.WriteLine($"i:{i},tempCol:{tempCol},count:{count}");
//     tempRow = i;//OV
//     Console.WriteLine($"i:{i},tempCol:{tempCol},count:{count}");

// }


