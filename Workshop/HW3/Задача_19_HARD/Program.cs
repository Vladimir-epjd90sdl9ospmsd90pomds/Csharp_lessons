// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 
//Через строку нельзя решать само собой.

double decs(int num)
{
    int count = 0;
    for (int i = num; i > 10; i /= 10) //Нашли разрядность числа
    {
        count++;
    }
    return Math.Pow(10, count);
}

void compare(int num, double decs)
{
    int decsInt = Convert.ToInt32(decs);
    int count = 0;
    for (int i = decsInt; i > 0; i /= 10)
    {
        if ((num / i) % 10 != (num / Convert.ToInt32((Math.Pow(10, (count)))) % 10))
        {
            Console.WriteLine("Нет");
            break;
        }
        else if (i <= 10 && i > 0)
        {
            Console.WriteLine("Да");
            break;
        }
        count++;
    }
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

compare(num, decs(num));

