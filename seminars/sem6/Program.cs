// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharsToString(char[] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.Length; i++)
//     {
//         str += chars[i];
//     }
//     return str;
// }

// char[] chars = {'a', 'b','c','d'};
// Console.WriteLine(CharsToString(chars));

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] StringToChars(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void PrintChars(char[] chars)
// {
//     for (int i = 0; i < chars.Length; i++)
//     {
//         Console.Write($"{chars[i]}, ");
//     }
// }

// string str = "Hello!";
// PrintChars(StringToChars(str));

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

char[] chars = {'a', 'e','i','o','u','y'};

int CheckChar(string str)
{
    int sum = 0;
    foreach (char item in str)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            if (item == chars[i])
                sum += 1;
        }
    }
    return sum;
}

Console.Write("Input string:");
string strr = Console.ReadLine();
Console.WriteLine(CheckChar(strr));
