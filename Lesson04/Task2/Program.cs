int[,] CreateMatrix(int min, int max)
{
    int [,] matrix = new int [min, max];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1, 1000);
            }
        }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
        return true;
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

int [,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
        Console.Write($"{e}\t");
}
