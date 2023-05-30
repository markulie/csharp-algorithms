namespace IsPrime;

internal abstract class Program
{
    public static void Main()
    {
        while (true)
        {
            int number = GetPositiveIntegerFromUser();
            bool isPrime = IsPrime(number);
            Console.WriteLine($"{number} is {(isPrime ? "" : "NOT ")}a prime number. ");
        }
    }

    private static int GetPositiveIntegerFromUser()
    {
        while (true)
        {
            Console.Write("Enter a positive integer: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number > 0) return number;
            Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
        }
    }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number is 2 or 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        int sqrtNumber = (int)Math.Sqrt(number);
        for (int i = 5; i <= sqrtNumber; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0) return false;
        }

        return true;
    }
}