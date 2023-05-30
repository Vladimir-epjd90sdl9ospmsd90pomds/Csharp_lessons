//Lecture2

// int[] array = new int[10];
// void MakeArray(int[] array)
// {
//     int count = 0;
//     int number = 0;
//     while (count < array.Length)
//     {
//         number = new Random().Next(1, 10);
//         array[count] = number;
//         count++;
//     }
// }

// void ShowArray(int[] arr)
// {
//     int count = 0;
//     while (count < arr.Length)
//     {
//         Console.Write(arr[count] + " ");
//         count++;
//     }
//     Console.WriteLine();
// }

// int FindNumber(int[] all, int num)
// {
//     int count = 0;
//     while (count < all.Length)
//     {
//         if (all[count] == num)
//         {
//             Console.WriteLine("Позиция в массиве: " + count);
//             break;
//         }
//         count++;
//     }
//     return num;
// }

// MakeArray(array);
// ShowArray(array);
// FindNumber(array, 5);

//Lecture3 

// int[] array = { 5, 6, 7, 6, 2, 7, 1, 6, 9, 3, 2, 4, 1, 5 };
// void minMax(int[] arr)
// {
//     //int arrLength = arr.Length;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int max = i;
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] > arr[max])
//             {
//                 max = j;
//             }

//         }
//         int tempMax = arr[i];
//         arr[i] = arr[max];
//         arr[max] = tempMax;
//         Console.Write($"{arr[i]} ");
//     }
// }

// minMax(array);