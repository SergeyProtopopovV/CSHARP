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

bool CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);

Console.Write("Input value to check: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckNumInArray(array, value));
