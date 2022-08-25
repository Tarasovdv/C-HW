// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\ny = {k1}x + {b1}");
Console.WriteLine($"y = {k2}x + {b2}");

double leftValue = k1 + -(k2);
double rightValue = b2 + -(b1);

Console.WriteLine($"leftValue = {leftValue}\nrightValue = {rightValue}\n");

double x = rightValue / leftValue;
double y = k1 * x + b1;

Console.WriteLine($"Intersection point: ({x}, {y})");