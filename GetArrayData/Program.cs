int[] arr = {15, 23, 36, 17, 18};
foreach (int i in arr) Console.Write(i + " ");

Console.WriteLine("\r\n");

int max = arr[0], min = arr[0], sum = 0, even = 0, odd = 0;

foreach (int i in arr)
{
    sum += i;
    if (i > max) max = i;
    else if (i < min) min = i;
    else if (i % 2 == 0 && i > even) even = i;
    else if (i > odd) odd = i;
}

int average = sum / arr.Length;

Console.WriteLine($"Summary: {sum} \r\n Average: {average} \r\n Max: {max} \r\n Min: {min} \r\n Even: {even} \r\n Odd: {odd}");