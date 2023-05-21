// // Семинар. Задание 1.
// Console.WriteLine("Введите целое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Квадрат вашего числа: " + num * num);

// // Семинар. Задание 2.
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2) Console.WriteLine("Число " + num2 + " является квадратом числа " + num1);
// else if (num2 * num2 == num1) Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
// else Console.WriteLine("Ни одно из чисел не является квадратом другого");

// // Семинар. Задание 3.
// Console.Write("Укажите порядковый номер дня недели: ");
// string dayNum = Console.ReadLine();
// if (dayNum == "1") Console.WriteLine("Это понедельник");
// else if (dayNum == "2") Console.WriteLine("Это вторник");
// else if (dayNum == "3") Console.WriteLine("Это среда");
// else if (dayNum == "4") Console.WriteLine("Это четверг");
// else if (dayNum == "5") Console.WriteLine("Это пятница");
// else if (dayNum == "6") Console.WriteLine("Это суббота");
// else if (dayNum == "7") Console.WriteLine("Это воскресенье");
// else Console.WriteLine("Такого дня не существует");

// // Семинар. Задание 4.
// Console.Write("Укажите рабочее число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = num1 * -1;
// if (num1 > 0)
// {
//     int count = num1;
//     while (count >= num2)
//     {
//         Console.WriteLine(count);
//         count--;
//     }
// }
// else if (num1 < 0)
// {
//     int count = num1;
//     while (count <= num2)
//     {
//         Console.WriteLine(count);
//         count++;
//     }
// }
// else Console.WriteLine("Вы ввели ноль");

// // Семинар. Задание 5.
// Console.Write("Укажите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num % 10;
// Console.WriteLine("Последняя цифра данного числа: " + result);



// // ДЗ. Задача 2
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2) Console.Write("max = " + num1);
// else if (num1 < num2) Console.Write("max = " + num2);
// else Console.Write("Они равны");

// ДЗ. Задача 4
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("Наибольшее число: " + max);
