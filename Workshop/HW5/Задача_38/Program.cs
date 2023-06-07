// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.

Console.WriteLine("Введите количество элементов массива:");
int numOfArrItems = Convert.ToInt32(Console.ReadLine());
int[] myArr = new int[numOfArrItems];

void ArrayGen(int[] geningArr)
{
    for (int i = 0; i < geningArr.Length; i++)
    {
        geningArr[i] = new Random().Next(0, 100);
    }
}

void Print(int[] printingArray)
{
    foreach (int item in printingArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void FindingDifference(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine(min);
    Console.WriteLine(max);

}

ArrayGen(myArr);
Print(myArr);
FindingDifference(myArr);
