// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Задача 38:");


double[] array = new double[6];
int arrSize = array.Length;
double diffMinMax = 0;

for (int i = 0; i < arrSize; i++)
{
    array[i] = new Random().NextDouble() * 100;
}
Console.WriteLine($"Array [ {String.Join("; ", array)} ]");
Array.Sort(array);
Console.WriteLine($"ArraySort [ {String.Join("; ", array)} ]");
Console.WriteLine($"Different: MaxValue - MinValue = {array[arrSize - 1] - array[0]}");