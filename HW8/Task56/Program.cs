// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

int rows = 3;
int columns = 4;

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

int[] SumRowElement(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        // Console.WriteLine(sum);
        sumArray[i] = sum;
    }
    return sumArray;
}

int SearchRowIndex(int[] sumArray)
{
    int minPosition = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        //minPosition = i;
        //Console.WriteLine(minPosition);
        for (int j = i + 1; j < sumArray.Length; j++)
        {
            if (sumArray[j] < sumArray[minPosition]) minPosition = j;
        }
    }
    return minPosition;
}

Console.WriteLine("Task 56");
int[,] matrix = FillArray(rows, columns);
PrintArray(matrix);
// Console.WriteLine(SumRowElement(matrix));
int[] sumArray = SumRowElement(matrix);

// Console.WriteLine($"sumArray = {String.Join(", ", sumArray)}");

int res = SearchRowIndex(sumArray);
Console.WriteLine($"Номер строки с минимальной суммой: {res + 1}");