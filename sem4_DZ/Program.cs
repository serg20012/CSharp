// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// // возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// int proverka(int a, int b)
// {
//     int sum = 1;
//     int coun = 0;
//     for (int i = 1; i <= b; i++)
//     {
//         sum = sum * a;
//         // Console.WriteLine(sum);
//         coun = coun + 1;
//         Console.Write(coun + " ");
//     }
//     return sum;
// }
// Console.Write("Введите число: возводимое в степень");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: степень");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write(proverka(a, b));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// void proverka(int num)
// {
//     int temp = num;
//     int sum = 0;
//     while (temp > 0)
//     {
//         int digit = temp % 10;
//         sum = digit + sum;
//         temp = temp / 10;

//     }
//     Console.WriteLine(sum);
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// proverka(num);


// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
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
// int[] myarray = CreateRandomArray(8);
