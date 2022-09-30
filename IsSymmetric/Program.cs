int origin = 3436343;
int num = origin;

int rev = 0;
while (num != 0)
{
    rev = rev * 10 + num % 10;
    num /= 10;
}

if (origin == rev) Console.WriteLine("Is Symmetric");
else Console.WriteLine("Is Asymmetric");

Console.ReadLine();