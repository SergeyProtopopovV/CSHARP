//Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{num} в квадрате -> {num * num}");

//напишите программу, которая принимает два числа и проверяет, является первое квадратом второго

//Console.WriteLine("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num2 * num2 == num1)
//{
//    Console.WriteLine($"{num1} является квадратом {num2}");
//} else
//{
//    Console.WriteLine($"{num1} не является квадратом {num2}");
//}

//напишите программу, которая принимает на вход целое N, а на выходе показывает все целые от -N до N

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = -n; i <= n; i++)
{
    Console.Write(i + " ");
}