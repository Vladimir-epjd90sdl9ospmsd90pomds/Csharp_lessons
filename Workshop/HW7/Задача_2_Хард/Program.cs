// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна
// с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и 
// только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2* 3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0,0 и 1,2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1,2 не трогаем, так как это уже перемещенные ячейки, выбираем 
//случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0,2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1,0 и 1,1, меняем их местами
// 4 5 3
// 9 1 2


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

int[] RightRowAndCol()
{
    int[] tempArrow2 = new int[2];
    Console.WriteLine("Введите кол-во строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows * columns % 2 == 0)
    {
        tempArrow2[0] = rows;
        tempArrow2[1] = columns;
        return tempArrow2;

    }
    else
    {
        Console.WriteLine("Количество строк или столбцов должно быть чётное:");
        return RightRowAndCol();
    }
}

int[] GenCoordsArray(int[,] arrForMod)
{
    string[] usedCoords = new string[arrForMod.GetLength(0) * arrForMod.GetLength(1) * 2];
    int[] tempCoord = new int[2];

    for (int j = 0; j < usedCoords.Length; j += 2)
    {
        void GenCoordsArray2(int[,] arrForMod, string[] usedCoords, int[] tempCoord)
        {

            string tempRow = Convert.ToString((new Random().Next(0, arrForMod.GetLength(0))));
            string tempCol = Convert.ToString((new Random().Next(0, arrForMod.GetLength(1))));
            tempCoord[0] = Convert.ToInt32(tempRow);
            tempCoord[1] = Convert.ToInt32(tempCol);
            for (int i = 0; i < usedCoords.Length - 2; i += 2)
            {
                if (tempCoord[0] == Convert.ToInt32(usedCoords[i]) && tempCoord[1] == Convert.ToInt32(usedCoords[i + 1])) GenCoordsArray2(arrForMod, usedCoords, tempCoord);
            }

        }
        GenCoordsArray2(arrForMod, usedCoords, tempCoord);
        usedCoords[j] = Convert.ToString(tempCoord[0]);

        usedCoords[j + 1] = Convert.ToString(tempCoord[1]);

    }

    int[] usedCoords2 = new int[usedCoords.Length];
    for (int i = 0; i < usedCoords2.Length; i++)
    {
        usedCoords2[i] = Convert.ToInt32(usedCoords[i]);
    }
    Print2D(arrForMod);
    // Print(usedCoords2);
    return usedCoords2;
}

// void Print1D(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

void ChangePlaces(int[,] mainArrow, int[] coordCombinations)
{
    int[] tempCoord2 = new int[2];


    for (int i = 0; i < coordCombinations.Length; i += 4)
    {
        int tempNum = mainArrow[coordCombinations[i], coordCombinations[i + 1]];
        mainArrow[coordCombinations[i], coordCombinations[i + 1]] = mainArrow[coordCombinations[i + 2], coordCombinations[i + 3]];
        mainArrow[coordCombinations[i + 2], coordCombinations[i + 3]] = tempNum;
    }
}


int[] rightTable = RightRowAndCol();
int[,] resultArrow = GenArrow(rightTable[0], rightTable[1]);
ChangePlaces(resultArrow, GenCoordsArray(resultArrow));
Print2D(resultArrow);
