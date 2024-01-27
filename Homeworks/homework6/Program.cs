// Урок 6. Массивы и строки

// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// char[,] MakeCharsArray(int rows, int columns)
// {
//     string abc = "abcdefghijklmnopqrstuvwxyz";
//     char[,] array = new char[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = abc[new Random().Next(0, 26)];
//         }
//     }
//     return array;
// }

// void PrintArray(char[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"'{array[i, j]}'\t");
//         }
//         Console.WriteLine();
//     }
// }

// string StrFromArray(char[,] array)
// {
//     string str = "";
//     foreach (char e in array)
//     {
//         str += e;
//     }
//     return str;
// }

// Console.Write("Input num of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of column: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// char[,] arr = MakeCharsArray(rows, columns);
// PrintArray(arr);
// Console.WriteLine($"String from array -> '{StrFromArray(arr)}'");


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string MakeString(int leng)
// {
//     string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//     string str = "";
//     for (int i = 0; i < leng; i++)
//     {
//         str += abc[new Random().Next(0, 52)];
//     }
//     return str;
// }

// void PrintString(string str)
// {
//     Console.WriteLine($"string -> '{str}'");
// }

// Console.Write("Input length of string: ");
// int leng = Convert.ToInt32(Console.ReadLine());
// string randStr = MakeString(leng);
// PrintString(randStr);
// string lowStr = randStr.ToLower();
// PrintString(lowStr);


// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// bool CheckIfPalindrom(string str)
// {
//     string revStr = "";
//     for (int i = 0; i < str.Length; i++)
//     {
//         revStr += str[str.Length - i - 1];
//     }
//     Console.WriteLine(revStr.ToLower().Replace(" ", "") + " " + str.ToLower().Replace(" ", ""));
//     if (revStr.ToLower().Replace(" ", "") == str.ToLower().Replace(" ", ""))
//     {
//         return true;
//     } else {
//         return false;
//     }    
// }

// Console.Write("Input string to check if it palidrome: ");
// string str = Console.ReadLine()!;
// Console.WriteLine(CheckIfPalindrom(str));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReverseWordsInString(string str)
{
    string revWordsStr = "";
    string[] array = str.Split(' ');
    for (int i = 0; i < array.Length; i++)
    {
        revWordsStr += array[array.Length - i - 1] + " ";
    }
    return revWordsStr;
}

Console.Write("Input string to reverse words: ");
string str = Console.ReadLine()!;
Console.WriteLine(str);
Console.WriteLine(ReverseWordsInString(str));
