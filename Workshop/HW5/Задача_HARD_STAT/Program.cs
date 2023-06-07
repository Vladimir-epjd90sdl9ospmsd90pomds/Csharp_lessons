// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива,
// возможно придется кое-что для этого дополнительно выполнить.


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

void FindExtrem(int[] arr)
{
    int[] newArr = new int[5];
    int max = 0;
    int maxIndex = 0;
    int min = 0;
    int minIndex = 0;
    int middleSum = 0;
    int sum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[maxIndex]) maxIndex = i;
        if (arr[i] < arr[minIndex]) minIndex = i;
        sum += arr[i];
    }
    Console.WriteLine($"Максимальный элемент: {arr[maxIndex]}, его индекс: {maxIndex}");
    Console.WriteLine($"Минимальный элемент: {arr[minIndex]}, его индекс: {minIndex}");
    Console.WriteLine($"Среднее арифметическое элементов массива: {sum / arr.Length}");

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

    if (arr.Length % 2 == 1)
    {
        Console.Write($"Медианное значение: {arr[arr.Length / 2]}");
    }
    else Console.Write($"Медианное значение: {(arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2}");
}

ArrayGen(myArr);
Print(myArr);
FindExtrem(myArr);
MedianaArr(myArr);
