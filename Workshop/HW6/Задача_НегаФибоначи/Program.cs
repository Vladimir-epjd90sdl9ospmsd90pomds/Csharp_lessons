// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


Console.WriteLine("Введите количество числ Фибоначи: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] fibonachiArr = new int[num];
fibonachiArr[0] = 0;
fibonachiArr[1] = 1;

void Fibonaci(int num)
{
    for (int i = 2; i < num; i++)
    {
        fibonachiArr[i] = fibonachiArr[i - 1] + fibonachiArr[i - 2];
    }
}

void NegaFibonaci(int[] myarr)
{
    int[] result = new int[myarr.Length * 2 - 1];
    for (int i = 0; i < myarr.Length * 2 - 1; i++)
    {
        if (i < myarr.Length && i % 2 == 0) result[i] = myarr[myarr.Length - 1 - i] * -1;
        else if (i < myarr.Length && i % 2 != 0) result[i] = myarr[myarr.Length - 1 - i];
        else result[i] = myarr[i + 1 - myarr.Length];
    }
    Print(result);
}

void Print(int[] printingArray)
{
    foreach (int item in printingArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Fibonaci(num);
Print(fibonachiArr);
NegaFibonaci(fibonachiArr);
