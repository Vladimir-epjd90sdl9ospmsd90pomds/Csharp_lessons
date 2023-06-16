// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,] GenArrow(int arr0, int arr1)
{
    int[,] tempArray = new int[arr0, arr1];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            void unicTest(int i, int j)
            {
                tempArray[i, j] = new Random().Next(0, 10);
                for (int k = 0; k <= i; k++)
                {
                    if (k == i)
                    {
                        for (int l = 0; l < j; l++)
                        {
                            if (tempArray[k, l] == tempArray[i, j]) unicTest(i, j);
                        }
                    }
                    else
                    {
                        for (int l = 0; l < tempArray.GetLength(1); l++)
                        {
                            if (tempArray[k, l] == tempArray[i, j]) unicTest(i, j);
                        }
                    }
                }

            }
            unicTest(i, j);
        }
    }

    // for (int i = 0; i < tempArray.GetLength(0); i++)
    // {
    //     for (int j = 0; j < tempArray.GetLength(1); j++)
    //     {
    //         for (int k = 0; k < tempArray.GetLength(2); k++)
    //         {
    //             int unicTest(int i, int j, int k, int[,,] tempArray)
    //             {
    //                 int tempArray2 = new Random().Next(1, 10);
    //                 for (int l = 0; l < i + 1; l++)
    //                 {
    //                     for (int m = 0; m < j + 1; m++)
    //                     {
    //                         for (int n = 0; n < k; n++)
    //                         {
    //                             if (tempArray[l, m, n] == tempArray2) unicTest(i, j, k, tempArray);
    //                             else return tempArray2;
    //                             //tempArray[i, j, k] = tempArray2;
    //                         }
    //                     }
    //                 }
    //                 // tempArray[i, j, k] = tempArray2;
    //             }

    //             tempArray[i, j, k] = unicTest(i, j, k, tempArray);
    //         }
    //     }
    // }
    return tempArray;
}

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


Console.WriteLine("Введите кол-во эл-тов 1го измерения:");
int arr0 = 4;//Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во эл-тов 2го измерения:");
int arr1 = 2;//Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во эл-тов 3го измерения:");
int arr2 = 2;//Convert.ToInt32(Console.ReadLine());

int[,] resultArrow = GenArrow(arr0, arr1);
Print2D(resultArrow);
