//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Clear();
Console.WriteLine("Task 64:");
Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + ", " + PrintNumbers(start + 1, end);
}

Console.WriteLine($"M = {m}; N = {n} -> [{PrintNumbers(m, n)}] ");