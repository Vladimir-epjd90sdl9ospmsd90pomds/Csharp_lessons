
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Укажите количество вводимых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());

void result(int numOfNums)
{
    int sum = 0;
    int value = 0;
    for (int i = 0; i < numOfNums; i++)
    {
        Console.WriteLine("Введите число:");
        value = Convert.ToInt32(Console.ReadLine());
        if (value > 0) sum += 1;
    }
    Console.WriteLine($"Количество положительных чисел: {sum}");
}

result(num);