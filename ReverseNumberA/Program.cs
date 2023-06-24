int num = 480456833;

while (num != 0)
{
    int a = num % 10;
    num /= 10;
    Console.Write(a);
}