//Lecture2

int[] array = new int[10];

void MakeArray(int[] array)
{
    int count = 0;
    int number = 0;
    while (count < array.Length)
    {
        number = new Random().Next(1, 10);
        array[count] = number;
        count++;
    }
}

void ShowArray(int[] arr)
{
    int count = 0;
    while (count < arr.Length)
    {
        Console.Write(arr[count] + " ");
        count++;
    }
    Console.WriteLine();
}

int FindNumber(int[] all, int num)
{
    int count = 0;
    while (count < all.Length)
    {
        if (all[count] == num)
        {
            Console.WriteLine("Позиция в массиве: " + count);
            break;
        }
        count++;
    }
    return num;
}

MakeArray(array);
ShowArray(array);
FindNumber(array, 5);

