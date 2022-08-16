int attemptCounter = 0;
int attempt;
Random number = new Random();
do
{
    attempt = number.Next(1, 10000000);
    Console.WriteLine("Number - " + attempt);
    attemptCounter++;
}
while (attempt != 20);

Console.WriteLine($"Total number of attempts - {attemptCounter}");

Console.ReadLine();