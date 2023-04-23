// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных элементов массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int GetSumOfNegatives(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sum += array[i];
//     }
//     return sum;
// }
// Console.Write("кол-во");
// int size = Convert.ToInt32(Console.ReadLine);
// Console.Write("мин валуе");
// int min = Convert.ToInt32(Console.ReadLine);
// Console.Write("мах валуе");
// int max = Convert.ToInt32(Console.ReadLine);

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// // Выводим результат
// Console.WriteLine("Сумма отрицательных элементов массива: " + GetSumOfNegatives(myArray));

// задача в зал №1
// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

// задача в зал №2
// Задайте массив.Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.

// задача в зал №3
// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [a,b].

Задача 4 для группы 4 новый мо
public static int[] Return(int[] arr)
{

    int count = 0;
    int length = arr.Length / 2;
    int[] arrOut = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrOut[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrOut;
}