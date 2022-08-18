// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Enter the number");
double num = Convert.ToDouble(Console.ReadLine());
double powNum;
int count = 1;

while (count <= num)
{
    powNum = Math.Pow(count, 3);
    Console.WriteLine($"{count}^3 -> {powNum}");
    count++;
}