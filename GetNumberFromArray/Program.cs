int[] arr = { 45, 45, 5, 8, 1000, 85754, 5 };

bool anyNum = false;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 100)
    {
        anyNum = true;
        break;
    }
}

if (anyNum) Console.WriteLine("There is!");
else Console.WriteLine("is not..");

Console.ReadLine();