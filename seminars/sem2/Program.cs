//Напишите программу, котрая принимает на вход 3-х значное число
//и удаляет среднюю цифру
// a = 256 -> 26

// void deleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         Console.WriteLine($"{num} -> {num / 100 * 10 + num % 10}");
//     }
//     else
//     {
//         Console.WriteLine("Число не 3-х значное");
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// deleteSecondDigit(number);

//напишите программу, которая принимает на вход 3-х значное число и выдает вторую цифру
//возведенную в степень третьей
// a = 324 -> 16    a = 617 -> 1

// int secondToThird(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         return (int)Math.Pow(dec, ed);
//     }
//     return 0;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(secondToThird(number));

void ABC()
{
    int randnum = new Random().Next(10, 99 + 1);
    Console.WriteLine(randnum);
}

ABC();
