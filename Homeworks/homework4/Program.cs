// Урок 4. Функции

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// bool IsItQ(string num)
// {
//     if (num = 'q')
//     {
//         return true;
//     }
//     return false;
// }

// bool IsSumEven(string num)
// {
//     int number = Convert.ToInt32(num);
//     if (number < 10)
//     {
//         int summ = number; 
//     } else {
//         int summ = 0;
//         while (number > 0)
//         {
//             summ += number % 10;
//             number /= 10;
//         }
//     }
//     if (summ % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// Console.Write("Input number or q to exit: ");
// string num = Console.ReadLine();
// while (IsItQ(num) || IsSumEven(num) is not)
// {
//     Console.Write("Input number or q to exit: ");
//     string num = Console.ReadLine();
// }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     } 
//     Console.WriteLine();
// }

// int EvenNumCounter(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         count++;
//     } 
//     return count;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// PrintArray(array);
// Console.WriteLine($"В массиве {EvenNumCounter(array)} четных чисел");

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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
    int[] reverseArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - i - 1];
    }
    return reverseArray;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
PrintArray(CreateReverseArray(array));
