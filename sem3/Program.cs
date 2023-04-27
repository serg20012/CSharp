// задача 1
// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), и выдаёт номер четверти плоскости, в которой находится эта точка.
// public static int returnCoord(double x, double y)
// {
//     int coord;
//     if (x > 0 && y > 0)
//     {
//         return coord = 1;
//     }
//     else if (x < 0 && y > 0)
//     {
//         return coord = 2;
//     }
//     else if (x < 0 && y < 0) return coord = 3;
//     else return coord = 4;
// }
// Console.WriteLine("Plese, enter coord x");
// double coordX = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Plese, enter coord y");
// double coordY = Convert.ToDouble(Console.ReadLine());
// double terurnRes = returnCoord(coordX, coordY);
// Console.WriteLine($"Ваша координатная плоскость {terurnRes}");

// задача 2 void
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 1 - 1
// 2 - 4
// 3 - 9
// 4 -16
// void Main(int num1)
// {
//     Console.WriteLine("Таблица квадратов от 1 до " + num1 + ":");
//     for (int i = 1; i <= num1; i++)
//     {
//         Console.WriteLine(i + " * " + i + " = " + (i * i));
//     }
// }
// Console.WriteLine("Введите число N: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Main(num1);

// Задача 3
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// Console.Write("Введите координату X первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine("Расстояние между точками: " + distance);

// =====defauвариант 2
double Gipot(double x1, double y1, double x2, double y2)
{
    double distX = x2 - x1;
    double distY = y2 - y1;
    double result = Math.Sqrt(distX * distX + distY * distY);
    return result;
}
Console.Write("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Расстояние между точками 1 и 2  составляет  - {Gipot(x1, y1, x2, y2)}");