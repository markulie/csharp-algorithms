int num = 456428567;

while (num != 0)
{
    int n = num % 10;
    num /= 10;
    if (n is 2 or 3 or 5 or 7) Console.Write($"{n}, ");
}

Console.ReadLine();