int num = 48456833;

int max = 0;
while (num != 0)
{
    int a = num % 10;
    num /= 10;
    if (a > max) max = a;
}

Console.WriteLine(max);

Console.ReadLine();