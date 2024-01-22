// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

int[,]  CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Find(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
}

Console.Write("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num of column: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array minimum: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array maximum: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);
// Find(array);
// Console.WriteLine();
// PrintMatrix(array);

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int DiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + matrix[i, j];
        }
    }
    return sum;
}

// int[,] array = CreateMatrix(rows, columns, min, max);
// PrintMatrix(array);
// Console.WriteLine();
// Console.WriteLine(DiagonalSum(array));

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

double[] SrArArray(int[,] array)
{
    double[] srArray = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        srArray[i] = sum / array.GetLength(1);
    }
    return srArray;
}

void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();
}

int[,] array = CreateMatrix(rows, columns, min, max);
PrintMatrix(array);
Console.WriteLine();
PrintArray(SrArArray(array));

