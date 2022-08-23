// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Задача 36:");


int[] array = new int[6];
int arrSize = array.Length;
int sumOddPositionValue = 0;

for (int i = 0; i < arrSize; i++)
{
    array[i] = new Random().Next(5);
}


for (int j = 1; j < arrSize; j += 2)
{
    sumOddPositionValue += array[j];
}

Console.WriteLine($"Array [ {String.Join("; ", array)} ] -> {sumOddPositionValue}");
