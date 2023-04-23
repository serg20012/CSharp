// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int x)
// {
//     int[] array = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         // Console.Write(i + " "); // это проверка

//         Console.Write(array[i] + " ");
//     }
//     return array;
// }
// void proverka(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.Write(count);
// }
// int[] x = CreateRandomArray(10); //кол-во ячеек массива 10
// Console.WriteLine();
// proverka(x);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int x)
// {
//     int[] array = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//         // Console.Write(i + " "); // это проверка

//         Console.Write(array[i] + " ");
//     }
//     return array;
// }
// void proverka(int[] array)
// {
//     int count = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         count = count + array[i];
//     }
//     Console.Write(count);
// }
// int[] x = CreateRandomArray(10); //кол-во ячеек массива 10
// Console.WriteLine();
// proverka(x);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] CreateRandomArray(int x)
// {
//     int[] array = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//         // Console.Write(i + " "); // это проверка

//         Console.Write(array[i] + " ");
//     }
//     return array;
// }
// void proverka(int[] array)
// {
//     int minznak = array[1];
//     int maxznak = array[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (minznak > array[i])
//         {
//             minznak = array[i];
//         }
//         if (maxznak < array[i])
//         {
//             maxznak = array[i];
//         }
//     }
//     Console.Write(maxznak - minznak);
// }
// int[] x = CreateRandomArray(10); //кол-во ячеек массива 10
// Console.WriteLine();
// proverka(x);