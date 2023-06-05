int[] array = new int[100];

for (int i = 0; i < 99; i++)
{
    array[i] = 0;
}

Random random = new();
int randomIndex = random.Next(1, 100);
array[randomIndex] = 1;

foreach (int i in array)
{
    if (i == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(1);
        Console.ResetColor();
    }
    else
    {
        Console.Write(i);
    }
}

Console.WriteLine();
Console.WriteLine(array.Length);

(int, int) index2 = MyMethod(array);
Console.WriteLine("Index: " + index2.Item1 + ", Attempts: " + index2.Item2);

static (int, int) MyMethod(int[] x)
{
    int attempts = 0;
    int length = x.Length;
    int half = length / 2;

    for (int i = half; i < length; i++)
    {
        attempts++;
        if (x[i] == 1) return (i, attempts);
    }

    for (int i = half - 1; i > 0; i--)
    {
        attempts++;
        if (x[i] == 1) return (i, attempts);
    }

    return (-1, attempts);
}