int n = 2;
n = Math.Abs(n);

bool isPrime = true;
if (n == 2) isPrime = true;
else if (n < 2 || n % 2 == 0) isPrime = false;
else
{
    double nSqrt = Math.Sqrt(n);
    for (int i = 3; i <= nSqrt; i += 2)
    {
        if (n % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime) Console.WriteLine($"Yes, {n} is a Prime Number! :)");
else Console.WriteLine($"No, {n} is NOT Prime Number! :(");

Console.ReadLine();