// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

Console.WriteLine("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nArray ({rows}, {columns}) = ");

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  |  ");
        }
        Console.WriteLine();
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("|  ↓  ");
    }
    Console.Write("|");
}




int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine("\n");

double[] sum = new double[columns];
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[j] += Convert.ToDouble(array[i, j]);

    }
    double arithmeticMean = Math.Round(sum[j] / columns, 1);
    Console.Write("| ");
    Console.Write($"{arithmeticMean} ");
}
Console.Write("|");
