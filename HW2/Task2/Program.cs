// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Task #2: ");

void Greeting() // Приветствие
{
    Console.WriteLine("Enter a  number: ");
}
string Enter() // Ввод числа
{
    string num = Console.ReadLine();
    Console.WriteLine("\nnum = " + num);
    return num;
}
bool CheckNum(string num) // Проверка числа на трехзначность
{
    if (num.Length >= 3)
    {

        return true;
    }
    else
    {
        Console.WriteLine($"{num} -> there is no third digit");
        return false;
    }

}

Greeting();
string num = Enter();
bool check = CheckNum(num);
if(check) Console.WriteLine($"{num} -> {num[2]}");


