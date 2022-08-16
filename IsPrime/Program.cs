int number;
string isNot;
string? again;

do
{
    Console.Write("Enter a positive integer: ");
    number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    isNot = "";
    if (!CheckPrimeNumber(number)) isNot = "not ";
    Console.Write($"{number} is {isNot}a prime number. ");

    Console.Write("Again? (yes or no) ");
    again = Console.ReadLine();
} while (again == "yes");


static bool CheckPrimeNumber(int number)
{
    bool isPrime = true;
    if (number == 2) isPrime = true;
    else if (number < 2 || number % 2 == 0) isPrime = false;
    else
    {
        double nSqrt = Math.Sqrt(number);
        for (int i = 3; i <= nSqrt; i += 2)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    return isPrime;
}