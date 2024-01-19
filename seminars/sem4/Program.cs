// задайте одномерный массив, заполненный случайными числами.
// определиите количество простых чисел в этом массиве.
// [1 3 4 19 3] -> 2
// [4 3 4 1 9 5 21 13] -> 3

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();
}

int SimpleNumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 1 && array[i] % 2 != 0 || array[i] == 2)
            if (array[i] % 3 != 0 || array[i] == 3)
                if (array[i] % 5 != 0 || array[i] == 5)
                    if (array[i] % 7 != 0 || array[i] == 7)
                        count++;

    } 
    return count;
}

int NumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        count++;
    } 
    return count;
}

int ArrayToNum(int[] array)
{
    string str = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];
    } 
    return Convert.ToInt32(str);
}

int DigitCounter(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// Console.WriteLine(ArrayToNum(array));

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
Console.WriteLine(DigitCounter(number));
