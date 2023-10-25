// Создание Сортировки Массива по посчету если в нем только Цифры.

void PrintArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}

int[] PullArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {   
        array[i] = rnd.Next(0, 9); 
    }
    return array;
}

int[] SortArray(int[] array)
{
    int[] arr = new int[array.Length];
    int number = 0;
    int count = 0;  
    for (int i = 0; i < 10; i++)
    {
        for(int j = 0; j < array.Length; j++)
        {
            if (array[j] == number)
            {
                count++;
                arr[number] = count;
            }
        }
        if (count == 0) arr[number] = 0;
        count = 0;
        number++;
    }
    PrintArray(arr);
    number = 0;
    count = 0;
    int count1 = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++) if (array[j] == number) count++;
        if (count != 0) for (int j = 0; j < count; j++) arr[j + count1] = number;
        count1 += count;
        if (count1 >= arr.Length) break;
        number++;
        count = 0;
    }
    return arr;
}

int[] array = new int[10];
PullArray(array); 
PrintArray(array);
int[] arr = SortArray(array);
PrintArray(arr);