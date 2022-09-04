// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.WriteLine("Enter number of rows of the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of the array: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Rows: {rows}");
Console.WriteLine($"Columns: {col}");

int value = 1;
int x = 0; // текущее положение ячейки (строка)
int y = -1; // текущее положение ячейки (столбец) начинаем смотреть из ВНЕ матрицы
int driveRow = 0; // движение по строкам -1 = вверх. 0 = по строке. 1 = вниз 
int driveCol = 1; // движение по колонке -1 = влево. 0 = по столбцу. 1 = вправо

int[,] FillArray(int rows, int columns)
{
    int[,] fillArray = new int[rows, columns];

    for (int i = 0; i < fillArray.GetLength(0); i++)
    {
        for (int j = 0; j < fillArray.GetLength(1); j++)
        {
            fillArray[i, j] = 0;
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

int[,] array = FillArray(rows, col);
PrintArray(array);

while (value <= rows * col)
{
    if (0 <= (x + driveRow) && (x + driveRow) < rows
        && 0 <= (y + driveCol) && (y + driveCol) < col
        && array[x + driveRow, y + driveCol] == 0)
    {

        x += driveRow;
        y += driveCol;
        array[x, y] = value;
        value++;

    }
    else
    {
        if (driveCol == 1)
        {
            driveCol = 0;
            driveRow = 1;
        }
        else if (driveRow == 1)
        {
            driveRow = 0;
            driveCol = -1;
        }
        else if (driveCol == -1)
        {
            driveCol = 0;
            driveRow = -1;
        }
        else if (driveRow == -1)
        {
            driveRow = 0;
            driveCol = 1;
        }
    }
}
PrintArray(array);




