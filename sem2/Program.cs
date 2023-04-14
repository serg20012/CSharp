//ДЗ2
// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// num1 = (num1 / 10) % 10;
// Console.WriteLine(num1);


// Задача 13: Напишите программу, которая выводит третью цифру слева
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326790 -> 6

// Console.WriteLine("Введите число");
// int vvod = Convert.ToInt32(Console.ReadLine());
// int coteiner = vvod;
// if (vvod > 99)
// {
//     while (coteiner > 1000)
//     {
//         coteiner = coteiner / 10;
//     }
//     coteiner = coteiner % 10;
//     Console.WriteLine($"Третья цифра числа: {coteiner}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет.");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели от 1-7:");
// int vvod = Convert.ToInt32(Console.ReadLine());
// if (vvod == 6 || vvod == 7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("не выходной");
// }