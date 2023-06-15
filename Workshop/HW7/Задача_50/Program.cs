// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Gen2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void Print2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine("");
    }
}

void CheckNum(int[,] arr)
{
    Console.WriteLine("Введите число для проверки его наличия в массиве: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int check = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                Console.WriteLine($"Позиция данного числа в массиве: ({i}, {j})");
                check++;
            }
        }
    }
    if (check == 0) Console.WriteLine("Число отсутствует в массиве");

}


Console.WriteLine("Укажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество колонок: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] geningArray = new int[row, col];

Gen2DArray(geningArray);
Print2D(geningArray);
CheckNum(geningArray);