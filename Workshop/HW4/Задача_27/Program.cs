// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int sumOfNums(int num)
{
    int result = 0;
    for (int i = num; i > 1; i /= 10)
    {
        result += (i % 10);
    }
    return result;
}

Console.WriteLine(sumOfNums(num));