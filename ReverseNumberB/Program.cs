int num = 480456833;

int a = 0;
while (num != 0)
{
    a = a * 10 + num % 10;
    num /= 10;
}

Console.WriteLine(a);