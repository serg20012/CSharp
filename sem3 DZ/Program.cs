// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// void proverka(int num)
// {
//     int temp = num;
//     int reverse_num = 0;
//     while (temp > 0)
//     {
//         int digit = temp % 10;
//         reverse_num = (reverse_num * 10) + digit;
//         temp = temp / 10;
//     }
//     if (num == reverse_num)
//         Console.WriteLine("Число является палиндромом");
//     else
//         Console.WriteLine("Число не является палиндромом");
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// proverka(num);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void rasstoynie(int xa, int ya, int za, int xb, int yb, int zb)
// {
//     double dlina = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
//     dlina = Math.Round(dlina, 2);
//     if (dlina < 0) dlina = dlina * -1;
//     else Console.WriteLine(dlina);
// }
// Console.Write("координату X точки A: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("координату Y точки A: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("координату Z точки A: ");
// int za = Convert.ToInt32(Console.ReadLine());

// Console.Write("координату X точки B: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("координату Y точки B: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("координату Z точки B: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// rasstoynie(xa, ya, za, xb, yb, zb);

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// void cub(int num)
// {
//     int count = num;
//     for (int i = 1; i < num + 1; i++)
//     {
//         double result = Math.Pow(i, 3);
//         Console.Write($"{result}, ");
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// cub(num);