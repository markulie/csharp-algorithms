int attempt = 0;
int randomNumber;
Random rnd = new();
do
{
    randomNumber = rnd.Next(1, 100000);
    Console.WriteLine($"Number - {randomNumber}");
    attempt++;
} while (randomNumber != 777);

Console.WriteLine($"Total number of attempts - {attempt}");

Console.ReadLine();