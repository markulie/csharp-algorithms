int[] arr = { 15, 23, 36, 17, 18 };
foreach (var item in arr) Console.Write(item.ToString()+" ");
Console.WriteLine();
Console.WriteLine();

int max = arr[0];
int min = arr[0];
int sum = 0;
int even = 0;
int odd = 0;

for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
    if (arr[i] > max) max = arr[i];
    else if (arr[i] < min) min = arr[i];
    else if (arr[i] % 2 == 0 && arr[i] > even) even = arr[i];
    else if (arr[i] > odd) odd = arr[i];
}
int average = sum / arr.Length;

Console.WriteLine($"Summary: {sum}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Even: {even}");
Console.WriteLine($"Odd: {odd}");

Console.ReadLine();