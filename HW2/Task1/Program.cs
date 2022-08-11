//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Task #1: ");

void Greeting() // Приветствие
{
    Console.WriteLine("Enter a three-digit number: ");
}
int Enter() // Ввод числа
{
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nnum = " + num);
    return num;
}
bool CheckNum(int num) // Проверка числа на трехзначность
{
    if ((num / 100 >= 1) && !(num / 100 >= 10)) return true;
    else
    {
        Console.WriteLine("You entered an incorrect number/ please repeat\n");
        return false;
    }
}
int TwoDigitCalculation(int num) // Вычисление второго знака
{
    int twoDidit = (num % 100) / 10;
    return twoDidit;
}

bool check = false;
while (!check)
{
    Greeting();
    int num = Enter();
    check = CheckNum(num);
    if (check)
    {
        Console.WriteLine("Two digit value:\n" + num + " -> " + TwoDigitCalculation(num));

    }
}



