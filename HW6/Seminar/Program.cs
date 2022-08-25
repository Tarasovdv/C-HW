// переворот массива


// int[] array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 11);
// }

// Console.WriteLine($"Array       [ {String.Join("; ", array)} ]");

// int[] resultArray = new int[array.Length];

// int lastIndex = array.Length - 1;
// for (int i = 0; i < array.Length; i++)
// {
//     resultArray[i] = array[lastIndex - i];
// }
// Console.WriteLine($"ResultArray [ {String.Join("; ", resultArray)} ]");

// существует ли треугольник

Console.Clear();
Console.WriteLine("Enter 1 side");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2 side");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3 side");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник НЕ существует");
    
