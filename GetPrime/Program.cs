int num = 456428567;

int n = 0;
while (num != 0)
{
    n = num % 10;
    num /= 10;
    if (n == 2 || n == 3 || n == 5 || n == 7) Console.Write($"{n}, ");
}

Console.ReadLine();