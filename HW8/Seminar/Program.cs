// двумерный массив
// заменить местами первую и последнюю строчку

Console.Clear();


// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows != columns) 
// {
//     Console.WriteLine("Заменить элементы нельзя");
//     return;
// }

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // метод замены строк

// void ChangeRows(int[,] matrix)
// {
//     int indexLastRows = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[indexLastRows, i];
//         matrix[indexLastRows, i] = temp;
//     }
// }

// // метод замены строк на столбцы

// int[,] ChangeArray(int[,] matrix)
// {
//     int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[j, i] = matrix[i, j];
//         }
//     }

//     return result;
// }


// int[,] array = GetArray(rows, columns);
// PrintArray(array);
// // ChangeRows(array);
// // PrintArray(array);
// int [,] changeArray = ChangeArray(array);
// PrintArray(changeArray);

// убрать строку и столбец где есть минимальный элемент
int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];

int minElement = int.MaxValue;
int indexMinRows = 0;
int indexMinColumns = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        if (minElement > matrix[i, j])
        {
            indexMinColumns = j;
            indexMinRows = i;
            minElement = matrix[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine(minElement);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (indexMinRows != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexMinColumns != j)
            {
                Console.Write(matrix[i, j] + "\t");

            }
        }
    Console.WriteLine();
    }

}