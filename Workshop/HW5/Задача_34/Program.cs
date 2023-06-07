// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов массива:");
int numOfArrItems = Convert.ToInt32(Console.ReadLine());
int[] myArr = new int[numOfArrItems];

void ArrayGen(int[] geningArr)
{
    for (int i = 0; i < geningArr.Length; i++)
    {
        geningArr[i] = new Random().Next(100, 1000);
    }
}

int FindingPositive(int[] arr)
{
    int result = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0) result++;
    }
    return result;
}

void Print(int[] printingArray)
{
    foreach (int item in printingArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

ArrayGen(myArr);
Print(myArr);
Console.WriteLine(FindingPositive(myArr));