// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Random array generation");
Console.WriteLine("Enter Array Length");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 10);
}

Console.WriteLine($"array [{length}] = [{String.Join("; ", array)}]");


