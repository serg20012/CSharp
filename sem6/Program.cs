// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

// void ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }

// }
// Console.Write("кол-во");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("мин валуе");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("мах валуе");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);

// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// void triangleExists(int a, int b, int c)
// {
//     if ((a < b + c) && (b < a + c) && (c < a + b))
//     {
//         Console.WriteLine("Треугольник с такими сторонами существует");
//     }
//     else
//     {
//         Console.WriteLine("Треугольник с такими сторонами не существует");
//     }
// }
// Console.Write("Введите сторону A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону C: ");
// int c = Convert.ToInt32(Console.ReadLine());
// triangleExists(a, b, c);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.
// Console.Write("Введите количество чисел Фибоначчи: ");
// int n = int.Parse(Console.ReadLine());

// int a = 0;
// int b = 1;
// Console.Write($"{a} {b} ");

// for (int i = 2; i < n; i++)
// {
//     int c = a + b;
//     Console.Write($"{c} ");
//     a = b;
//     b = c;
// }

// Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.
// int[] originalArray = { 1, 2, 3, 4, 5 };
// int[] copiedArray = new int[originalArray.Length];

// for (int i = 0; i < originalArray.Length; i++)
// {
//     copiedArray[i] = originalArray[i];
// }
// ShowArray(originalArray);
// ShowArray(copiedArray);
