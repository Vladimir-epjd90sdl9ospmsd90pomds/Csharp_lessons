// // Семинар1. Задание 1.
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



// // Семинар 4. Задача 32.

// int[] arr = new int[4] { -4, -8, 8, 2 };
// void Changing(int[] changingArray)
// {
//     int[] result = new int[changingArray.Length];
//     int i = 0;
//     foreach (int item in changingArray)
//     {
//         result[i] = -1 * item;
//         i++;
//     }
//     arr = result;
// }
// void Print(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
// }
// Changing(arr);
// Print(arr);



// int[] arr = new int[5] { 6, 7, 19, 345, 3 };
// int num = 6;
// void Finding(int[] findingNum)
// {
//     bool yn = false;
//     foreach (int item in findingNum)
//     {
//         if (item == num) yn = true;
//         break;
//     }


//     if (yn) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");
// }

// Finding(arr);





// // Семинар 4. Задача 35.

// Console.WriteLine("Введите количество элементов массива:");
// int numOfArrItems = Convert.ToInt32(Console.ReadLine());



// int[] ArrayGen(int num)
// {
//     int[] newArr = new int[num];
//     for (int i = 0; i < newArr.Length; i++)
//     {
//         newArr[i] = new Random().Next(0, 123);
//     }
//     return newArr;
// }

// void Print(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// void ArrFilter(int[] arrayForFiltering)
// {
//     int filteredResult = 0;
//     foreach (int item in arrayForFiltering)
//     {
//         if (item >= 10 && item <= 99) filteredResult++;
//     }
//     Console.WriteLine(filteredResult);
// }

// int[] result = ArrayGen(numOfArrItems);
// Print(result);
// ArrFilter(result);




// // Семинар 4. Задача 37.
// Console.WriteLine("Введите количество элементов массива:");
// int numOfArrItems = Convert.ToInt32(Console.ReadLine());
// int[] myArr = new int[numOfArrItems];

// void ArrayGen(int[] geningArr)
// {
//     for (int i = 0; i < geningArr.Length; i++)
//     {
//         geningArr[i] = new Random().Next(1, 11);
//     }
// }

// void Print(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// void SummOf(int[] multingArray)
// {
//     int resultLength = 0;
//     if (multingArray.Length % 2 > 0) resultLength = (multingArray.Length / 2) + 1;
//     else resultLength = multingArray.Length / 2;
//     int[] result = new int[resultLength];
//     int j = 0;
//     for (int i = 0; i < multingArray.Length; i++)
//     {
//         j = multingArray.Length - i - 1;
//         if (i - j == 0)
//         {
//             result[i] = multingArray[i];
//             break;
//         }
//         else if (j - i == 1)
//         {
//             result[i] = multingArray[i] * multingArray[j];
//             break;
//         }
//         else result[i] = multingArray[i] * multingArray[j];

//     }
//     Console.WriteLine(result.Length);
//     Print(result);
// }
// ArrayGen(myArr);
// Print(myArr);
// SummOf(myArr);






// Семинар 5. Задача 40. 

// void Triangle(int length_1, int length_2, int length_3)
// {
//     if (length_1 < length_2 + length_3 && length_2 < length_1 + length_3 && length_3 < length_1 + length_2)
//         Console.WriteLine("Да, такой треугольник может существовать");
//     else Console.WriteLine("Нет, такого треугольника не может существовать");
// }

// Console.WriteLine("Введите длину 1й стороны: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину 2й стороны: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину 3й стороны: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Triangle(x, y, z);





// // Семинар 5. Задача 42. // Конвертит десятичные в двоичные, через массив
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int arrLength = MakeArrayLength(num);
// int[] result = new int[arrLength];
// int i = 0;

// int MakeArrayLength(int num1)
// {
//     int k = 0;
//     for (int j = num1; j >= 1; j /= 2)
//     {
//         k++;
//     }
//     return k;
// }

// void ToBi(int num2, int i)
// {
//     if (num2 >= 1)
//     {
//         result[i] = num2 % 2;
//         num2 /= 2;
//         i++;
//         ToBi(num2, i);
//     }
// }

// void Moving(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
//     }
// }

// void Print(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// //Print(result);
// ToBi(num, i);
// Moving(result);
// Print(result);


// //Семинар 5. Задача 44.
// Console.WriteLine("Введите количество числ Фибоначи: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] fibonachiArr = new int[num];
// fibonachiArr[0] = 0;
// fibonachiArr[1] = 1;

// void Fibonaci(int num)
// {
//     for (int i = 2; i < num; i++)
//     {
//         fibonachiArr[i] = fibonachiArr[i - 1] + fibonachiArr[i - 2];
//     }
// }

// void NegaFibonaci(int[] myarr)
// {
//     int[] result = new int[myarr.Length * 2 - 1];
//     for (int i = 0; i < myarr.Length * 2 - 1; i++)
//     {
//         if (i < myarr.Length && i % 2 == 0) result[i] = myarr[myarr.Length - 1 - i] * -1;
//         else if (i < myarr.Length && i % 2 != 0) result[i] = myarr[myarr.Length - 1 - i];
//         else result[i] = myarr[i + 1 - myarr.Length];
//     }
//     Print(result);
// }

// void Print(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// Fibonaci(num);
// Print(fibonachiArr);
// NegaFibonaci(fibonachiArr);



// //Семинар 7. Задача 48.

// int[,] FillArrow(int rowQuantity, int colQuentity)
// {
//     int[,] resultArrow = new int[rowQuantity, colQuentity];
//     for (int i = 0; i < resultArrow.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultArrow.GetLength(1); j++)
//         {
//             resultArrow[i, j] = i + j;
//         }
//     }
//     return resultArrow;
// }

// void Print(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],2}");
//         }
//         Console.WriteLine();
//     }

// }

// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// Print(FillArrow(rows, columns));



// //Семинар 7. Задача 49.

// int[,] FillArrow(int rowQuantity, int colQuentity)
// {
//     int[,] tempArrow = new int[rowQuantity, colQuentity];
//     for (int i = 0; i < tempArrow.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArrow.GetLength(1); j++)
//         {
//             tempArrow[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return tempArrow;
// }

// void ModificatedArrow(int[,] arrForMod)
// {
//     for (int i = 0; i < arrForMod.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrForMod.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) arrForMod[i, j] *= arrForMod[i, j];
//         }
//     }

// }

// void Print(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resultArrow = FillArrow(rows, columns);
// Print(resultArrow);
// ModificatedArrow(resultArrow);
// Print(resultArrow);




// // //Семинар 7. Задача 51.

// int[,] GenArrow(int rowQuantity, int colQuentity)
// {
//     int[,] tempArrow = new int[rowQuantity, colQuentity];
//     for (int i = 0; i < tempArrow.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArrow.GetLength(1); j++)
//         {
//             tempArrow[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return tempArrow;
// }

// void ArrowScoring(int[,] arrForScan)
// {
//     int resultFirst = 0;
//     int resultSecond = 0;
//     for (int i = 0; i < arrForScan.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrForScan.GetLength(1); j++)
//         {
//             if (i == j) resultFirst = resultFirst + arrForScan[i, j];
//             if (i == arrForScan.GetLength(1) - j - 1) resultSecond = resultSecond + arrForScan[i, j];
//         }
//     }
//     Console.WriteLine($"Сумма главной диагонали: {resultFirst}");
//     Console.WriteLine($"Сумма главной диагонали: {resultSecond}");

// }

// void Print(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resultArrow = GenArrow(rows, columns);
// Print(resultArrow);
// ArrowScoring(resultArrow);
// Print(resultArrow);



// // //Семинар 7. Задача ХЗ.

// int[,] GenArrow(int rowQuantity, int colQuentity)
// {
//     int[,] tempArrow = new int[rowQuantity, colQuentity];
//     for (int i = 0; i < tempArrow.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArrow.GetLength(1); j++)
//         {
//             tempArrow[i, j] = new Random().Next(0, 64);
//         }
//     }
//     return tempArrow;
// }

// void SortMinToMax(int[] arrForSort)
// {
//     for (int i = 0; i < arrForSort.Length; i++)
//     {
//         //      int min = arrForSort[i];
//         int tempMin = 0;
//         for (int j = i + 1; j < arrForSort.Length; j++)
//         {
//             if (arrForSort[j] < arrForSort[i])
//             {
//                 tempMin = arrForSort[j];
//                 arrForSort[j] = arrForSort[i];
//                 arrForSort[i] = tempMin;
//             }
//         }

//     }
//     //   Print1D(arrForSort);
// }

// void ArrowSorting(int[,] arrForScan)
// {
//     int[] tempArray = new int[arrForScan.GetLength(0) * arrForScan.GetLength(1)];
//     int count1 = 0;
//     for (int i = 0; i < arrForScan.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrForScan.GetLength(1); j++)
//         {
//             tempArray[count1] = arrForScan[i, j];
//             count1++;
//         }
//     }
//     //   Print1D(tempArray);
//     SortMinToMax(tempArray);
//     int count2 = 0;
//     for (int i = 0; i < arrForScan.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrForScan.GetLength(1); j++)
//         {
//             arrForScan[i, j] = tempArray[count2];
//             count2++;
//         }
//     }
// }

// void Print2D(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Print1D(int[] printingArray)
// {
//     foreach (int item in printingArray)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resultArrow = GenArrow(rows, columns);
// Print2D(resultArrow);
// ArrowSorting(resultArrow);
// Print2D(resultArrow);





// // //Семинар 7. Задача ХЗ второй вариант решения.

// int[,] GenArrow(int rowQuantity, int colQuentity)
// {
//     int[,] tempArrow = new int[rowQuantity, colQuentity];
//     for (int i = 0; i < tempArrow.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArrow.GetLength(1); j++)
//         {
//             tempArrow[i, j] = new Random().Next(0, 64);
//         }
//     }
//     return tempArrow;
// }

// void ArrowSorting(int[,] arrForScan)
// {
//     int temp = 0;
//     for (int i = 0; i < arrForScan.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrForScan.GetLength(1); j++)
//         {
//             for (int k = i; k < arrForScan.GetLength(0); k++)
//             {
//                 for (int l = j; l < arrForScan.GetLength(1); l++)
//                 {
//                     if (arrForScan[k, l] < arrForScan[i, j])
//                     {
//                         temp = arrForScan[k, l];
//                         arrForScan[k, l] = arrForScan[i, j];
//                         arrForScan[i, j] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }

// void Print2D(int[,] printingArray)
// {
//     for (int i = 0; i < printingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printingArray.GetLength(1); j++)
//         {
//             Console.Write($"{printingArray[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите кол-во строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resultArrow = GenArrow(rows, columns);
// Print2D(resultArrow);
// ArrowSorting(resultArrow);
// Print2D(resultArrow);