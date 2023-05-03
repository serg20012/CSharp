// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// double[,] arr2d(int rows, int columns, int min, int max)
// {
//     double x = 0;
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             x = new Random().Next(min * 100, max * 100 + 1);
//             array[i, j] = x / 100; //способ получения дробного числа придумал рома саморай 
//         }
//     }
//     return array;
// }
// void show2d(double[,] array)
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
// Console.Write("строки ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("столбцы ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("min значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("max значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = arr2d(rows, columns, min, max);
// show2d(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7->числа с такими индексами в массиве нет
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
// string proverka(int[,] array, int x, int y)
// {
//     int xreal = array.GetLength(0);
//     int yreal = array.GetLength(1);
//     if (xreal >= x && yreal >= y)
//     {
//         return array[y, x].ToString(); //x номер столбца, y номер строки 
//     }
//     else
//     {
//         return ("числа с такими индексами в массиве нет");
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

// Console.Write("x искомое (отсчет от 0) ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("y искомое (отсчет от 0) ");
// int y = Convert.ToInt32(Console.ReadLine());
// string result = proverka(myArray, x, y);
// Console.Write(result);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] arr2d(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);

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
void sredArifmit(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0.00;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        sum = sum / array.GetLength(0);
        sum = Math.Round(sum, 2);
        Console.Write(sum + " ");
    }
}
Console.Write("строки ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("столбцы ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("min значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = arr2d(rows, columns, min, max);
show2d(myArray);
sredArifmit(myArray);