// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// void MToN(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write(m + " ");
//         MToN(m + 1, n);
//     }
// }

// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// MToN(m, n);


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

// Описание функции Аккермана:
// A(m,n) = n+1, если m=0
// A(m,n) = A(m-1,1), если m>0 и n=0
// A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0

// int Acker(int m, int n)
// {
//     if (m == 0)
//       return n + 1;
//     if (n == 0)
//       return Acker(m - 1, 1);
//     return Acker(m - 1, Acker(m, n - 1));
// }

// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"A({m},{n}) = {Acker(m, n)}");

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

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
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
        return;
    Console.Write($"{array[index]}\t");
    PrintArrayReverse(array, index - 1);
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
PrintArrayReverse(array, array.Length - 1);
