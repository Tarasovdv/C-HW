// 31.

Console.Clear();

int[] arr = new int[12];
int resultPositive = 0;
int resultNegative = 0;
int arraySize = arr.Length;

for (int i = 0; i < arraySize; i++)
{
    arr[i] = new Random().Next(-9, 10);
    // Console.Write(arr[i] +", ");
}

Console.WriteLine($"Array: [ {String.Join("; ", arr)} ]");

for (int j = 0; j < arraySize; j++)
{
    if (arr[j] < 0) resultNegative += arr[j];
    else resultPositive += arr[j];
}
Console.WriteLine($"ResultPositive: {resultPositive} \nResultNegative: {resultNegative}");