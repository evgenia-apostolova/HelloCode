int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[1]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i--)
    {
        int maxPosition = i;

        for (int j = i - 1; j < array.Length + 1; j++) 
        {
            if (array[j] < array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
        Console.Write($"{array[1]} ");
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
