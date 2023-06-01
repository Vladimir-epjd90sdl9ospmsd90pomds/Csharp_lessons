// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите возводимое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в которую хотите возвести число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int myPowFunction(int num1, int num2)
{
    int result = num1;
    for (int i = 2; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}

Console.WriteLine($"Результат возведения: {myPowFunction(num1, num2)}");