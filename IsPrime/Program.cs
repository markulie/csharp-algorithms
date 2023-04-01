while (true)
{
    int number = GetPositiveIntegerFromUser();
    bool isPrime = CheckPrimeNumber(number);
    Console.WriteLine($"{number} is {(isPrime ? "" : "NOT ")}a prime number. ");
}

static int GetPositiveIntegerFromUser()
{
    while (true)
    {
        Console.Write("Enter a positive integer: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number) && number > 0) return number;
        Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
    }
}

static bool CheckPrimeNumber(int number)
{
    if (number == 2) return true;
    else if (number < 2 || number % 2 == 0) return false;
    else
    {
        double sqrtNumber = Math.Sqrt(number);
        for (int i = 3; i <= sqrtNumber; i += 2)
        {
            if (number % i == 0) return false;
        }
    }

    return true;
}