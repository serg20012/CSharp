﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void CreateArray(int x)
// {
//     int[] array = new int[x];
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"введи число {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] > 0) { count = count + 1; }
//     }
//     Console.WriteLine();
//     Console.Write($"чисел больше нуля - {count}");
// }

// Console.Write("Сколько чисел будем вводить: ");
// int n = Convert.ToInt32(Console.ReadLine());
// CreateArray(n);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения: ({x}; {y})");
