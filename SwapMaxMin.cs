int[] arr = { 3, 1, 6, 4 };

int max = arr[0];
int maxIndex = 0;
int min = arr[0];
int minIndex = 0;
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

for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");

Console.ReadLine();