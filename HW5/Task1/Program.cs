// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Задача 34:");


int[] threeDigitArray = new int[10];
int arrSize = threeDigitArray.Length;
int count = 0;

for (int i = 0; i < arrSize; i++)
{
    threeDigitArray[i] = new Random().Next(100, 1000);
}

Console.WriteLine($"Array [ {String.Join("; ", threeDigitArray)} ]");

for (int j = 0; j < arrSize; j++)
{
    if (threeDigitArray[j] % 2 == 0) count ++;
}

Console.WriteLine($"Колличество четных элементов в массиве: {count}");