// Задайте массив. Напишите программу, которая определяет, есть ли заданное число в массиве.
// Программа должна выдать ответ Да/Нет.

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

int[] CreateReverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

bool CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

int[] PairsCount(int[] array)
{
    int[] tempArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempArray[i] = array[i] * array[array.Length - i - 1];
    }
    return tempArray;
}

int[] NumToArray(int num)
{
    if (num >= 100 && num <= 999)
    {
        int[] array = new int[3];
        int ed = num % 10;
        int dec = num / 10 % 10;
        int sot = num / 100;
        array[0] = ed;
        array[1] = dec;
        array[2] = sot;
        return array;
    }
    else
    {
        Console.WriteLine("Число не 3-х значное");
        return null;
    }
}


// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input array minimum: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input array maximum: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// PrintArray(PairsCount(array));

// Console.Write("Input value to check: ");
// int value = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 3-digit number: ");
int value = Convert.ToInt32(Console.ReadLine());
PrintArray(NumToArray(value));

// Console.WriteLine(CheckNumInArray(array, value));
