int[] arr = { 24234, 23131, 599657568, 313123, 67567, 92123123, 23234, 132131 };

int maxArr = arr[0];
int maxIndex = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (maxArr < arr[i])
    {
        maxArr = arr[i];
        maxIndex = i;
    }
}

int max = 0;
while (maxArr != 0)
{
    int a = maxArr % 10;
    maxArr /= 10;
    if (max < a) max = a;
}

Console.WriteLine($"Max Number: {max}, Index: {maxIndex}");