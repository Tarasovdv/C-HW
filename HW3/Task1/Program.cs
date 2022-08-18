// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Enter five-digit number");
string fiveDigitNumber = Console.ReadLine();
string reversFiveDigitNumber = string.Empty;

for (int i = fiveDigitNumber.Length - 1; i >= 0; i--)
{
    reversFiveDigitNumber += fiveDigitNumber[i];
}

if (fiveDigitNumber == reversFiveDigitNumber) Console.WriteLine($"{fiveDigitNumber} -> is Palindrome.");
else Console.WriteLine($"{fiveDigitNumber} -> is NOT Palindrome");





