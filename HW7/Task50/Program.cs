// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(rows, columns);
PrintArray(array);

Console.WriteLine("Enter element position: ");
Console.WriteLine("Rows number: ");
int rowNum = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Columns number: ");
int colNum = Convert.ToInt32(Console.ReadLine()) - 1;


for (int i = 0; i < array.GetLength(0); i++)
{
    if (rowNum + 1 > rows || colNum + 1 > columns)
    {
        Console.WriteLine($"Array[{rowNum + 1}, {colNum + 1}] = not found");
        break;
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == rowNum && j == colNum)
        {
            Console.Write($"Array [{rowNum + 1}, {colNum + 1}] = {array[i, j]}");
            break;
        }
    }
    
}