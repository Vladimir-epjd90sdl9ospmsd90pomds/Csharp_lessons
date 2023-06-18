// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Print3D(int[,,] printingArray)
{
    for (int i = 0; i < printingArray.GetLength(2); i++)
    {
        for (int j = 0; j < printingArray.GetLength(0); j++)
        {
            for (int k = 0; k < printingArray.GetLength(1); k++)
            {
                Console.Write($"{printingArray[j, k, i],5} ({j}, {k}, {i})");
            }
            Console.WriteLine();
        }

    }

}

// void Print1D(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// void Print2D(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Print3D(int[,,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < printingArray.GetLength(2); k++)
//             {
//                 Console.Write($"{printingArray[i, j, k],5} ({i}, {j}, {k})");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// void Make1DNoRepeatsArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int CheckPositions()
//         {
//             int tempNum = new Random().Next(0, 20);
//             for (int j = 0; j < i; j++)
//             {
//                 if (arr[j] == tempNum)
//                 {
//                     tempNum = CheckPositions();
//                 }
//             }
//             return tempNum;
//         }
//         CheckPositions();
//         arr[i] = CheckPositions();
//     }
// }

// void Make2DNoRepeatsArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             int CheckPositions()
//             {
//                 int tempNum = new Random().Next(0, 25);
//                 for (int j = 0; j <= i; j++)
//                 {
//                     if (j != i)
//                     {
//                         for (int l = 0; l < arr.GetLength(1); l++)
//                         {
//                             if (arr[j, l] == tempNum)
//                             {
//                                 return tempNum = CheckPositions();
//                             }

//                         }
//                     }
//                     else if (j == i)
//                     {
//                         for (int l = 0; l < k; l++)
//                         {
//                             if (arr[j, l] == tempNum)
//                             {
//                                 return tempNum = CheckPositions();
//                             }

//                         }
//                     }
//                 }
//                 return tempNum;
//             }
//             CheckPositions();
//             arr[i, k] = CheckPositions();
//         }
//     }
// }

void Make3DNoRepeatsArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int m = 0; m < arr.GetLength(1); m++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int CheckPositions()
                {
                    int tempNum = new Random().Next(0, 100);
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        for (int n = 0; n < arr.GetLength(1); n++)
                        {
                            for (int l = 0; l < arr.GetLength(2); l++)
                            {
                                if (arr[j, n, l] == tempNum)
                                {
                                    return tempNum = CheckPositions();
                                }
                            }
                        }
                    }
                    return tempNum;
                }
                //CheckPositions();
                arr[i, m, k] = CheckPositions();
            }
        }
    }
}




//Console.WriteLine("Введите кол-во эл-тов 1го измерения:");
int arr0 = 2;//Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите кол-во эл-тов 2го измерения:");
int arr1 = 2;//Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите кол-во эл-тов 3го измерения:");
int arr2 = 2;//Convert.ToInt32(Console.ReadLine());

//int[] arr1D = new int[arr0];
//Make1DNoRepeatsArray(arr1D);
//Print1D(arr1D);

// int[,] arr2D = new int[arr0, arr1];
// Make2DNoRepeatsArray(arr2D);
// Print2D(arr2D);

int[,,] arr3D = new int[arr0, arr1, arr2];
Make3DNoRepeatsArray(arr3D);
Print3D(arr3D);

