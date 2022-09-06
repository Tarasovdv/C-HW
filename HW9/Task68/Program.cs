// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// A(m,n) = n + 1 -> m = 0;
//          A( m-1, 1 ) -> m > 0, n = 0;                     
//          A( m-1, A(m, n-1)) -> m > 0, n > 0
//
//                         0        2
//          A(1 , 1) = A (1-1 , A(1, 0)) ---> 2+1 = 3 ОТВЕТ!!!
//                                   0
//                                A(1-1, 1) --> 2 

Console.Clear();
Console.WriteLine("Task 68:");
Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

// Console.WriteLine($"\nM = {m}\nN = {n}\nAkkerman Function Result = {AkkermanFunction(m, n)}");


// int[,] FillAkkArray(int n, int m)
// {
//     int[,] akkArray = new int[n, m];

//     for (int i = 0; i < akkArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < akkArray.GetLength(1); j++)
//         {
//             akkArray[i, j] = AkkermanFunction(m, n);
//         }
//     }
//     return akkArray;
// }

// void PrintAkkArray(int[,] akkArray)
// {
//     for (int i = 0; i < akkArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < akkArray.GetLength(1); j++)
//         {
//             Console.Write(akkArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] akkArray = FillAkkArray(n, m);
// PrintAkkArray(akkArray);
