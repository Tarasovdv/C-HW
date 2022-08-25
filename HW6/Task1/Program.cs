// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Task 41: ");

int[] array = new int[5];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    if (array[i] > 0 ) count++;
}

Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Positive values: {count}");