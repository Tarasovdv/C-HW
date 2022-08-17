// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
Console.WriteLine("Xa: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ya: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Za: ");
double za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"({xa},{ya},{za})");

Console.WriteLine("Введите координаты второй точки: ");
Console.WriteLine("Xb: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yb: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zb: ");
double zb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"({xb},{yb},{zb})");

double ab = Math.Round(Math.Sqrt((Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)) + Math.Pow((zb - za), 2)),2);
Console.WriteLine($"Расстояние между точками в пространстве: {ab}");



