// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Task #3: ");

void Greeting() // Приветствие
{
    Console.WriteLine("Enter the number indicating the day of the week: ");
}
int Enter() // Ввод числа
{
    int num = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("\nnum = " + num);
    return num;
}

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Greeting();
int dayNum = Enter();
if ((dayNum >= 1) && (dayNum < 6))
{
    Console.WriteLine($"\n{dayNum} -> Working day ({week[dayNum - 1]})");
}
else
{
    Console.WriteLine($"\n{dayNum} -> Weekend ({week[dayNum - 1]})");
}

