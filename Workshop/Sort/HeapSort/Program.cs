
void heapSort(int[] arr, int n)
{
    for (int i = n / 2 - 1; i >= 0; i--)
        heapify(arr, n, i);
    for (int i = n - 1; i >= 0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        heapify(arr, i, 0);
    }
}
void heapify(int[] arr, int n, int i)
{
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;
    if (left < n && arr[left] > arr[largest])
        largest = left;
    if (right < n && arr[right] > arr[largest])
        largest = right;
    if (largest != i)
    {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;
        heapify(arr, n, largest);
    }
}
void Start()
{
    int[] arr = { 21, 5, 121, 54, 16, 44, 95, 14, 30, 124, 74 };
    int n = 10, i;
    Console.Write("Первоначальный массив: ");
    for (i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
    heapSort(arr, 10);
    Console.Write("\nОтсортированный массив: ");
    for (i = 0; i < n; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Start();