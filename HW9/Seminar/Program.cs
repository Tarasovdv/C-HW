// Рекурсия

// int Fact(int n)
// {
//     //базовый - выход из рекурсии
//     if (n == 1) return 1;
//     //рекурсивный - задание самой рекурсии
//     return n * Fact(n - 1);
// }




// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     //базовый случай
//     if (start == end) return start.ToString();
//     //рекурсия
//     return (start + ", " + PrintNumbers(start + 1, end));

// }

// Console.WriteLine(PrintNumbers(m,  n));





// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers(int num)
// {
//     if (num == 0) return 0;

//     return (num % 10 + SumNumbers(num/10));
// }

// Console.WriteLine(SumNumbers(number));





int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());

int Power(int number, int degree)
{
    if (degree == 0) return 1;
    if (degree == 1) return number;

    return (number * Power(number, degree - 1));
}

Console.WriteLine(Power(number, degree));