// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Task 66:");
Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    int sum = start;
    if (start == end) return sum;
    return sum + SumNumbers(start + 1, end);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + " + " + PrintNumbers(start + 1, end);
}
Console.WriteLine($"\nM = {m}\nN = {n}\n ---> [{PrintNumbers(m, n)}] = {SumNumbers(m, n)}");