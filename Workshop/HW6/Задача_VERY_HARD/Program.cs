// Задача VERY HARD необязательная Имеется массив случайных целых чисел. 
// Создайте массив, в который попадают числа, описывающие максимальную 
// сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

// Console.WriteLine("Введите количество элементов массива:");
// int numOfArrItems = Convert.ToInt32(Console.ReadLine());
// int[] myArr = new int[numOfArrItems];

int[] myArr = new int[] { 1, 5, 3, 4, 1, 7, 8, 15, 1 };
int[] subArr = new int[myArr.Length];
int[] sub_2_Arr = new int[myArr.Length];
int[] sub_3_Arr = new int[myArr.Length];
int[] sub_4_Arr = new int[2];

// void ArrayGen(int[] geningArr) //Генератор массива без повторов
{
    // for (int i = 0; i < geningArr.Length; i++)
    // {
    //     geningArr[i] = new Random().Next(0, 50);
    // }

    //        int GenAndFindingRepeat(int[] geningArr) //отсев повторов
    //         {
    //             temp = new Random().Next(0, 21);
    //             foreach (int item in geningArr)
    //             {
    //                 if (temp == item) GenAndFindingRepeat(geningArr);
    //             }
    //             return temp;
    //         }
    //         geningArr[i] = GenAndFindingRepeat(geningArr);
}

void Print(int[] printingArray)
{
    foreach (int item in printingArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void MedianaArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        int tempMax = arr[i];
        arr[i] = arr[min];
        arr[min] = tempMax;
    }

}

void Filtrator(int[] myArr, int[] subArr, int[] subSubArr)
{
    for (int i = 0; i < myArr.Length; i++)
    {
        if (i == 0 && myArr[i + 1] - myArr[i] == 1) subArr[i] = 1;
        else if ((i != myArr.Length - 1 && myArr[i + 1] - myArr[i] == 1)) subArr[i] = 1;
    }

    for (int i = 0; i < subArr.Length; i++)
    {
        if (subArr[i] == 0) subSubArr[i] = 0;
        else if (subArr[i] == 1) subSubArr[i] = myArr[i];
    }

    int tic = 0;
    for (int i = 0; i < subArr.Length - 1; i++)
    {
        if ((subSubArr[i + 1] > 0 && subSubArr[i] == 0))
        {
            sub_3_Arr[tic] = sub_2_Arr[i + 1];
            tic++;
        }
        else if ((subSubArr[i] > 0 && subSubArr[i + 1] == 0))
        {
            sub_3_Arr[tic] = sub_2_Arr[i] + 1;
            tic++;
        }
    }

    int max = sub_3_Arr[1] - sub_3_Arr[0];
    sub_4_Arr[0] = sub_3_Arr[0];
    sub_4_Arr[1] = sub_3_Arr[1];
    for (int i = 2; sub_3_Arr[i] > 0; i += 2)
    {
        if (sub_3_Arr[i + 1] - sub_3_Arr[i] > max)
        {
            max = sub_3_Arr[i + 1] - sub_3_Arr[i];
            sub_4_Arr[0] = sub_3_Arr[i];
            sub_4_Arr[1] = sub_3_Arr[i + 1];
        }

    }
}

// ArrayGen(myArr);
Print(myArr);
MedianaArr(myArr);
// Print(myArr);
Filtrator(myArr, subArr, sub_2_Arr);
// Print(subArr);
// Print(sub_2_Arr);
// Print(sub_3_Arr);
Print(sub_4_Arr);