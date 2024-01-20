// Урок 2. Простые Алгоритмы

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// bool NumAliquot(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine($"Число {num} кратно 7 и 23 одновременно.");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} не кратно 7 или 23, или обоим числам.");
//         return false;
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(NumAliquot(number));

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// void QuaterChecker(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         Console.WriteLine("Точка находится на одной из координатных прямых");
//     }
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в 1-ой четверти");
//     }
//     if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится во 2-ой четверти");
//     }
//     if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится в 3-ей четверти");
//     }
//     if (x < 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в 4-ой четверти");
//     }
// }

// Console.Write("Input point coordinate X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input point coordinate Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// QuaterChecker(x, y);

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// void NumAnalize()
// {
//     int randnum = new Random().Next(10, 99 + 1);
//     Console.WriteLine($"Случайное число от 10 до 99 -> {randnum}");
//     int ed = randnum % 10;
//     int dec = randnum / 10;
//     if (ed > dec)
//     {
//         Console.WriteLine($"Наибольшая цифра в этом числе -> {ed}");
//     } else {
//         Console.WriteLine($"Наибольшая цифра в этом числе -> {dec}");
//     }
// }

// NumAnalize();

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// void NumSeparate(string number)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         Console.Write(number[i] + ", ");
//     }
// }

// Console.Write("Input number: ");
// string number = Console.ReadLine();
// NumSeparate(number);
