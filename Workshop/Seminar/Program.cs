﻿// // Семинар1. Задание 1.
// Console.WriteLine("Введите целое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Квадрат вашего числа: " + num * num);

// // Семинар1. Задание 2.
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2) Console.WriteLine("Число " + num2 + " является квадратом числа " + num1);
// else if (num2 * num2 == num1) Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
// else Console.WriteLine("Ни одно из чисел не является квадратом другого");

// // Семинар1. Задание 3.
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

// // Семинар1. Задание 4.
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

// // Семинар1. Задание 5.
// Console.Write("Укажите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num % 10;
// Console.WriteLine("Последняя цифра данного числа: " + result);

// // ДЗ1. Задача 2
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2) Console.Write("max = " + num1);
// else if (num1 < num2) Console.Write("max = " + num2);
// else Console.Write("Они равны");

// // ДЗ1. Задача 4
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.WriteLine("Наибольшее число: " + max);

// // ДЗ1. Задача 6
// Console.Write("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 0) Console.WriteLine("Введите число больше 0");
// else if (num % 2 == 0) Console.WriteLine("Число чётное");
// else Console.WriteLine("Число нечётное");

// // ДЗ1. Задача 8
// Console.Write("Введите положительное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// while (result <= num)
// {
//     if (result % 2 == 0) Console.Write(result + ", ");
//     result++;
// }

// // ДЗ1. Задача 7
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int dec = 10;
// int count = 1;
// if (num < 0) num = num * (-1);
// int result = num;
// if (num < 100) Console.WriteLine("Число слишком маленькое, введите число длиннее 3-х разрядов");
// else
// {
//     while (result > 0)
//     {
//         result = result / dec;
//         count = count * 10;
//     }
//     Console.WriteLine((num / (count / 1000)) % 10);
// }

// // Семинар 2. Задача 11.
// int num = new Random().Next(100, 1000);
// int num1 = num % 10;
// int num3 = num / 100;
// Console.WriteLine($" Изначально число такое: {num}");
// Console.WriteLine($" После обработки: {num3}{num1}");

// // Семинар 2. Задача 12.
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int dev = num1 % num2;
// if (dev == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Некратно, остаток {dev}");

// // Семинар 2. Задача 14.
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0) Console.Write("Да");
// else Console.Write("Нет");

// // Семинар 2. Задача 16.
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 * num1 == num2 || num2 * num2 == num1) Console.Write("Да");
// else Console.Write("Нет");





// // ДЗ_2, Задача_10
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool checkOfFraction(int num)
// {
//     if (num > 99 && num < 1000) return true;
//     else return false;
// }
// void findingNumber(int num)
// {
//     if (checkOfFraction(num)) Console.Write((num / 10) % 10);
//     else Console.Write("Введите именно трехзначное число");
// }
// findingNumber(num);

// // ДЗ_2, Задача_13
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool checkOfFraction(int num)
// {
//     if (num > 99) return true;
//     else return false;
// }
// int findingNumber(int num)
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     return num %= 10;
// }
// void go(int num)
// {
//     if (checkOfFraction(num)) Console.Write(findingNumber(num));
//     else Console.Write("Введите число больше 99");
// }
// go(num);

// // ДЗ_2, Задача_15
// Console.Write("Введите номер дня недели недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 5 && num < 8) Console.Write("Да");
// else Console.Write("Нет");



// //ДЗ_2, Задача_Необязательная_2
// int prompt()
// {
//     Console.WriteLine("Введите положительное количество студентов:");
//     int data = Convert.ToInt32(Console.ReadLine());
//     if (data >= 0) return data;
//     else return prompt();
// }
// string wordEndForm(int num)
// {
//     if (num > 9)
//     {
//         if (num % 10 == 1) return "";
//         else if (num % 10 >= 2 && num % 10 <= 4) return "а";
//         else return "ов";
//     }
//     else
//     {
//         if (num == 1) return "";
//         else if (num >= 2 && num <= 4) return "а";
//         else return "ов";
//     }
// }
// void wordForming(int num, string end)
// {
//     string answer = $"В аудитории {num} студент{end}";
//     Console.WriteLine(answer);
// }
// int data = prompt();
// wordForming(data, wordEndForm(data));


// //ДЗ_2, Задача_Необязательная_1
// decimal num = Convert.ToDecimal(Console.ReadLine());
// int whole = Convert.ToInt32(Math.Floor(num));
// if (whole < 10) Console.WriteLine("Надо было ввести вещественное число больше 10");
// else
// {
//     int count = 0;
//     int pseudowhole = whole;
//     while ((int)pseudowhole > 0)
//     {
//         count++;
//         pseudowhole /= 10;
//     }
//     decimal fraction = num - Math.Floor(num);
//     int firstnum = (whole / Convert.ToInt32(Math.Pow((double)10, (double)(count - 1)))) % 10;
//     string difOfWholeAndFirstnum = Convert.ToString(whole % Convert.ToInt32(Math.Pow((double)10, (double)(count - 2))));
//     if (difOfWholeAndFirstnum == "0")
//     {
//         difOfWholeAndFirstnum = "";
//     }
//     string firstPart = Convert.ToString(firstnum) + difOfWholeAndFirstnum;
//     decimal result = Convert.ToDecimal(firstPart) + fraction;

//     // Console.WriteLine(fraction);
//     // Console.WriteLine(firstnum);
//     // Console.WriteLine(difOfWholeAndFirstnum);
//     // Console.WriteLine(firstPart);
//     Console.WriteLine(result);
// }



// // // Семинар 3. Задача 18.
// void result(int x)
// {
//     switch (x)
//     {
//         case 1:
//             Console.WriteLine("х>0, y>0");
//             break;
//         case 2:
//             Console.WriteLine("х<0, y>0");
//             break;
//         case 3:
//             Console.WriteLine("х<0, y<0");
//             break;
//         case 4:
//             Console.WriteLine("х>0, y<0");
//             break;
//         default:
//             Console.WriteLine("Введите диапазон от 1 до 4");
//             break;
//     }
// }



// Console.WriteLine("Введите номер четверти");
// int x = Convert.ToInt32(Console.ReadLine());
// result(x);





// // // // Семинар 3. Задача 21.
// void lineLength(int aX, int aY, int bX, int bY)
// {
//     Console.WriteLine(Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2)));
// }

// Console.WriteLine("Введите координату x точки А:");
// int aX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки А:");
// int aY = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x точки B:");
// int bX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y точки B:");
// int bY = Convert.ToInt32(Console.ReadLine());

// lineLength(aX, aY, bX, bY);




// Семинар 3. Задача 22.
// void nums(int x)
// {
//     for (int i = 1; i <= x; i++)
//         Console.WriteLine(Math.Pow(i, 2));
// }
// Console.WriteLine("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// nums(x);


// // Семинар 4. Задача 22.
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int countOfNums(int num)
// {
//     int count = 0;
//     for (int i = num; i > 1; i /= 10)
//     {
//         count++;

//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр: {countOfNums(num)}");




// // Семинар 4. Задача 28.

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int multiply(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// Console.WriteLine($"Результат перемножения всех составляющих цифр числа: {multiply(num)}");


// // Семинар 4. Задача 30.
// int[] array01 = new int[8];
// int ran = 0;
// for (int i = 0; i < array01.Length; i++)
// {
//     ran = new Random().Next(0, 2);
//     array01[i] = ran;
//     Console.Write($"{array01[i]}");
// }