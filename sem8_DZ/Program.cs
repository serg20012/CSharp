// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int[,] arr2d(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(min, max + 1);

//     return array;
// }
// void show2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ReverseArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine(i + "строка ");
//         Console.ReadLine();
//         for (int predel = 0; predel < array.GetLength(1); predel++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1 - predel; j++)
//             {
//                 Console.Write(j + "круг сравниваем " + array[i, j] + "и" + array[i, j + 1]);
//                 Console.WriteLine();
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     // Console.Write(array[i, j] + " ");
//                     // Console.Write(array[i, j + 1] + "/");
//                     int temp = array[i, j]; array[i, j] = array[i, j + 1]; array[i, j + 1] = temp;
//                     Console.Write(array[i, j] + " поменяли ");
//                     Console.Write(array[i, j + 1]);
//                     Console.ReadLine();
//                 }
//                 Console.ReadLine();
//             }
//         }
//     }
// }

// Console.Write("строки ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("столбцы ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("min значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = arr2d(rows, columns, min, max);
// show2d(myArray);
// ReverseArray(myArray);
// show2d(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
// int[,] arr2d(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(min, max + 1);

//     return array;
// }
// void show2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void PoiskMinStrok(int[,] array)
// {
//     int[] result = new int[array.Length];
//     int minnomer = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[i] = result[i] + array[i, j];
//         }
//         // Console.WriteLine(result[i]);
//         if (i == 0) { minnomer = 1; minsum = result[0]; }
//         if (result[i] < minsum) { minnomer = i + 1; minsum = result[i]; }

//     }
//     Console.WriteLine("строка с минимальной суммой №" + minnomer);
// }

// Console.Write("строки ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("столбцы ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("min значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = arr2d(rows, columns, min, max);
// show2d(myArray);
// PoiskMinStrok(myArray);


// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18
// // int[,] arr2d()
// // {
// //     Console.Write("строки ");
// //     int rows = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("столбцы ");
// //     int columns = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("min значение ");
// //     int min = Convert.ToInt32(Console.ReadLine());
// //     Console.Write("max значение ");
// //     int max = Convert.ToInt32(Console.ReadLine());
// //     int[,] array = new int[rows, columns];

// //     for (int i = 0; i < rows; i++)
// //         for (int j = 0; j < columns; j++)
// //             array[i, j] = new Random().Next(min, max + 1);

// //     return array;
// // }
// int[,] myArray_1 = new int[,]{
//     {2,3,4},
//     {1,2,0},
//     {2,3,1}
// };
// int[,] myArray_2 = new int[,]{
//     {1,2},
//     {3,4},
//     {5,6}
// };
// void show2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] ProsvedenieMatrix(int[,] array_1, int[,] array_2)
// {
//     if (array_1.GetLength(1) != array_2.GetLength(0)) { Console.WriteLine("матрицы не умножить"); return null; }
//     int[,] result = new int[array_1.GetLength(0), array_2.GetLength(1)];
//     for (int j2 = 0; j2 < array_2.GetLength(1); j2++)
//         for (int i = 0; i < array_1.GetLength(0); i++)
//         {
//             int res = 0;
//             for (int j = 0; j < array_1.GetLength(1); j++)
//             {
//                 // Console.WriteLine(array_1[i, j] + " " + array_2[j, j2]);
//                 res = array_1[i, j] * array_2[j, j2] + res;
//                 // Console.ReadLine();
//             }
//             result[i, j2] = res;
//         }
//     return result;
// }
// // }
// // Console.WriteLine("данные для 1-й матрицы");
// // int[,] myArray_1 = arr2d();
// show2d(myArray_1);
// // Console.WriteLine("данные для 2-oй матрицы");
// // int[,] myArray_2 = arr2d();
// show2d(myArray_2);
// show2d(ProsvedenieMatrix(myArray_1, myArray_2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] myArray3d = new int[2, 2, 2]
// {
//     {
//     {66,25},
//     {27,90}
//     },
//     {
//     {34,26},
//     {41,55}
//     }
// };
// for (int sloy = 0; sloy < myArray3d.GetLength(0); sloy++)
// {
//     for (int i = 0; i < myArray3d.GetLength(1); i++)
//     {
//         for (int j = 0; j < myArray3d.GetLength(2); j++)
//             Console.Write(myArray3d[sloy, i, j] + "(" + sloy + "," + i + "," + j + ") ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr2d()
{
    Console.Write("строки ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("столбцы ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    int stop_j = columns - 1; int stop_i = rows - 1;
    int minstop_j = 0; int minstop_i = 1;
    int i = 0; int j = 0;
    int flag = 1; // 1 = вправо 2=вниз 3= влево 4= вверх;
    int znachenie = 10; array[i, j] = znachenie; // начало массива
    for (int stop = 1; stop < ((columns * rows) + 1); stop++)
    {
        Console.Write(i + "/" + j + " "); // это можно пофиксить
        znachenie = znachenie + 1;
        if (flag == 1 && j < stop_j) { j = j + 1; }
        if (flag == 2 && i < stop_i) { i = i + 1; }
        if (flag == 3 && j > minstop_j) { j = j - 1; }
        if (flag == 4 && i > minstop_i) { i = i - 1; }
        array[i, j] = znachenie;
        Console.WriteLine(array[i, j]); // это можно пофиксить

        if (flag == 1 && j == stop_j) { flag = 2; stop_j = stop_j - 1; }
        if (flag == 2 && i == stop_i) { flag = 3; stop_i = stop_i - 1; }
        if (flag == 3 && j == minstop_j) { flag = 4; minstop_j = minstop_j + 1; }
        if (flag == 4 && i == minstop_i) { flag = 1; minstop_i = minstop_i + 1; }
    }
    return array;
}
void show2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] myArray = arr2d();
show2d(myArray);