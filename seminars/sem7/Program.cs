// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return num % 10 + FindSum(num / 10);
//     }
//     return 0;
// }

// Console.WriteLine(FindSum(41234));

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

// void OneToN(int n)
// {
//     if (n > 0)
//     {
//         OneToN(n - 1);
//         Console.Write(n + " ");
//         // OneToN(n - 1);
//     }
// }

// OneToN(5);

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// char[] letter = {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'}
// // B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, W, X, Z

// void ConsonPrint(string str, int i)
// {
//     if ()
// }

// string str = Console.ReadLine();
// ConsonPrint(str);

void Sogl(string str, int i)
{
  if(i == str.Length)
    return;
  if(str[i] >= 'a' && str[i] <= 'z' && "aeiou".IndexOf(str[i]) == -1)
  {
    Console.Write(str[i]);
  }
  Sogl(str, i + 1);
}


string str = Console.ReadLine();
Sogl(str, 0);
