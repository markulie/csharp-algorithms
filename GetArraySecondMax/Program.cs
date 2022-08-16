int[] arr = { 3, 25, 6, 10, 99 };

int sum = 0;
for (int i = 0; i < arr.Length; i++) if (arr[i] % 5 == 0) sum += arr[i];
int average = sum / arr.Length;

Console.WriteLine(average);

Console.ReadLine();