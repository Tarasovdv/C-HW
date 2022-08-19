// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Enter the number: ");
string number = Console.ReadLine();

int length = number.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    int value = Convert.ToInt32(number[i].ToString());
    sum += value;
}
Console.WriteLine(sum);