// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nArray ({rows}, {columns}) = ");

double[,] FillArray(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(((new Random().NextDouble()) - (new Random().NextDouble())) * 100, 1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[,] array = FillArray(rows, columns);
PrintArray(array);


