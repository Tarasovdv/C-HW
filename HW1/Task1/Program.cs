// Task 1 : **Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Task #1");
Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int max = a;
    int min = b;
    Console.WriteLine("a = " + a + "; " + "b = " + b + " -> " + "max = " + max + "; " + "min = " + min);
}
else
{
    int max = b;
    int min = a;
    Console.WriteLine("a = " + a + "; " + "b = " + b + " -> " + "max = " + max + "; " + "min = " + min);
}
