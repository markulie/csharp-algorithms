int[] arr = { 3, 1, 6, 4 };

int max = arr[0], min = arr[0], maxIndex = 0, minIndex = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
        maxIndex = i;
    }
    else if (min > arr[i])
    {
        min = arr[i];
        minIndex = i;
    }
}
arr[maxIndex] = min;
arr[minIndex] = max;

foreach (int t in arr) Console.Write(t + "  ");

Console.ReadLine();