// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4


Console.WriteLine("Введите число:");
decimal num = Convert.ToDecimal(Console.ReadLine());

int numsAfterComma(decimal num)
{
    int count = 0;
    decimal whole = Math.Floor(num);
    decimal decPart = num - whole;
    for (decimal i = decPart; i > 0; i = (i * 10) - Math.Floor(i * 10))
    {
        count++;
    }
    return count;
}

int numsBeforeComma(decimal num)
{
    int i = Convert.ToInt32(Math.Floor(num));
    int count = 0;
    do
    {
        count++;
        i = i / 10;
    }
    while (i >= 1);
    return count;
}

Console.WriteLine($"Кол-во цифр в числе: {numsAfterComma(num) + numsBeforeComma(num)}");
