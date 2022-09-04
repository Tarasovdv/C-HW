// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

int rows = 2;
int columns = 2;

int[,] FillArray(int rows, int columns)
{
    int[,] fillArray = new int[rows, columns];

    for (int i = 0; i < fillArray.GetLength(0); i++)
    {
        for (int j = 0; j < fillArray.GetLength(1); j++)
        {
            fillArray[i, j] = new Random().Next(11);
        }
    }

    return fillArray;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine("Array: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int sum = 0;
    int count = 0;
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }

    }
    return resultArray;
}






Console.WriteLine("Task58");
int[,] matrix1 = FillArray(rows, columns);
PrintArray(matrix1);
int[,] matrix2 = FillArray(rows, columns);
PrintArray(matrix2);
int[,] resultArray = MultiplyArray(matrix1,matrix2);
PrintArray(resultArray);
