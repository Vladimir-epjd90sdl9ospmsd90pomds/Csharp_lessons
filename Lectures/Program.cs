//Lecture2

// int[] array = new int[1" "];
// void MakeArray(int[] array)
// {
//     int count = " ";
//     int number = " ";
//     while (count < array.Length)
//     {
//         number = new Random().Next(1, 1" ");
//         array[count] = number;
//         count++;
//     }
// }

// void ShowArray(int[] arr)
// {
//     int count = " ";
//     while (count < arr.Length)
//     {
//         Console.Write(arr[count] + " ");
//         count++;
//     }
//     Console.WriteLine();
// }

// int FindNumber(int[] all, int num)
// {
//     int count = " ";
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
//     for (int i = " "; i < arr.Length; i++)
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






//Lecture4

// string[,] matrix = new string[14, 14] {
//     {" "," "," "," "," "," "," "," "," "," "," "," "," "," "},
//     {" "," "," "," "," ","*","*","*","*","*"," "," "," "," "},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" ","*","*","*","*","*"," "," "," ","*","*","*","*","*"},
//     {" ","*"," "," "," "," "," "," "," "," "," "," "," ","*"},
//     {" ","*"," "," "," "," "," "," "," "," "," "," "," ","*"},
//     {" ","*"," "," "," "," "," "," "," "," "," "," "," ","*"},
//     {" ","*","*","*","*","*"," "," "," ","*","*","*","*","*"},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" "," "," "," "," ","*"," "," "," ","*"," "," "," "," "},
//     {" "," "," "," "," ","*","*","*","*","*"," "," "," "," "},
// };
// void arrayPrint(string[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// void recursionDrawing(string[,] matrix, int startDot0, int startDot1)

// {
//     if (matrix[startDot0, startDot1] == " ")
//     {
//         matrix[startDot0, startDot1] = "*";
//         recursionDrawing(matrix, startDot0 - 1, startDot1);
//         recursionDrawing(matrix, startDot0, startDot1 + 1);
//         recursionDrawing(matrix, startDot0 + 1, startDot1);
//         recursionDrawing(matrix, startDot0 - 1, startDot1 - 1);
//     }
// }

// int startDot0 = 8;
// int startDot1 = 2;

// arrayPrint(matrix);
// recursionDrawing(matrix, startDot0, startDot1);
// arrayPrint(matrix);
