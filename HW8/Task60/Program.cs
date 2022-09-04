// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int x = 2;
int y = 2;
int z = 2;

// bool CheckValue(int[,,] array3d, int value)
// {
//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//             {
//                 if (value == array3d[i, j, k])
//                 {
//                     return false;
//                     break;
//                 }
//             }
//         }
//     }
//     return true;

// }

int[,,] FillArray3d(int x, int y, int z)
{
    int[,,] array3d = new int[x, y, z];
    bool checkValue = false;

    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2);)
            {
                int randValue = new Random().Next(10, 100);
                for (int m = 0; m < i; m++)
                {
                    for (int n = 0; n < j; n++)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            if (array3d[m, n, l] == randValue)
                            {
                                    checkValue = true;
                            }
                        }
                    }
                }
                if(!checkValue)
                {
                    array3d[i, j, k] = randValue;
                    k++;
                }
            }
        }
    }
    return array3d;
}

void PrintArray(int[,,] matrix)
{
    Console.WriteLine("Array: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}{j}{k}) \t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] array3d = FillArray3d(x, y, z);
PrintArray(array3d);