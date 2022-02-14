int[] arr = { 3, 1, 6, 4, 3, 69, 34, 5, 11, 67 };

int max = arr[0];
int secondMax = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];
    else if (secondMax < arr[i] && arr[i] < max) secondMax = arr[i];
}

Console.WriteLine(secondMax);

Console.ReadLine();