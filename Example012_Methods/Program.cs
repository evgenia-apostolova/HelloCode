// Type 1
/*
void Method1()
{
    Console.WriteLine("Author ...");
}
Method1();
*/

// Type 2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Message text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
Method21(msg: "Text", count: 4);
*/
// Type 3
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Type 4
string Method4(int count, string text)
{
    int i = 0;
    string result = "";
    while (int i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
*/
/*
string Method4(int count, string text)
{
    string result = "";

for (int i = 0; i <count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/
/*
// Cycle inside cycle
//Таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//Задача Упорядочить массив
//Алгоритм сортировки методом выбора или методом min-max

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
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length - 1; j++) 
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        Console.Write($"{array[1]} ");
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);