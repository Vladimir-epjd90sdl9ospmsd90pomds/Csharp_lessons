// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int SumNums(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return SumNums(num1 - 1, 1);
    else return SumNums(num1 - 1, SumNums(num1, num2 - 1));
}

Console.Write("Введите число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNums(num1, num2));