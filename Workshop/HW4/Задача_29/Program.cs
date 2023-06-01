// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array01 = new int[8];
int ran = 0;
for (int i = 0; i < array01.Length; i++)
{
    ran = new Random().Next(0, 100);
    array01[i] = ran;
    Console.Write($"{array01[i]} ");
}