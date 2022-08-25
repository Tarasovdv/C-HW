// ДОП.ЗАДАЧА:
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.Clear();
Console.WriteLine("Enter Decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"DecimalNumber: {num}");

string binNum = String.Empty;
// Console.WriteLine(binNum);
// divisible - делимое
int divisible = num;
// divisor - делитель
int divisor = 2;
// quotient - частное от деления
int quotient = num;
// remainder - остаток от деления
int remainder;

while (quotient >= 2)
{
    quotient = divisible / divisor;
    remainder = divisible % divisor;
    binNum += Convert.ToString(remainder);
    divisible = quotient;
    
}

binNum += 1;
char[] charArray = binNum.ToCharArray();
Array.Reverse(charArray);
string binRes = new string (charArray);
Console.WriteLine($"BinaryNumber:  {binRes}");


