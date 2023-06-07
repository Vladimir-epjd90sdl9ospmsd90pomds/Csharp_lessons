// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите количество элементов массива:");
int numOfArrItems = Convert.ToInt32(Console.ReadLine());
int[] myArr = new int[numOfArrItems];

void ArrayGen(int[] geningArr)
{
    for (int i = 0; i < geningArr.Length; i++)
    {
        geningArr[i] = new Random().Next(-50, 50);
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

void SummingNotEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        result += arr[i];
    }
    Console.WriteLine(result);
}

ArrayGen(myArr);
Print(myArr);
SummingNotEven(myArr);