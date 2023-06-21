int[] array = new int[100];
for (int i = 0; i < 99; i++) array[i] = 0;

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
    else Console.Write(i);
}

(int, int) indexAndAttempts = FindIndexAndAttempts(array);
Console.WriteLine("\r\nIndex: " + indexAndAttempts.Item1 + ", Attempts: " + indexAndAttempts.Item2);

static (int, int) FindIndexAndAttempts(IReadOnlyList<int> array)
{
    int attempts = 0;
    int count = array.Count;

    for (int i = count / 2; i < count; i++)
    {
        attempts++;
        if (array[i] == 1)
        {
            return (i, attempts);
        }
    }
    for (int i = count / 2 - 1; i > 0; i--)
    {
        attempts++;
        if (array[i] == 1)
        {
            return (i, attempts);
        }
    }
    return (-1, attempts);
}