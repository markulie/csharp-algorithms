int min = 65;
int max = 564;

int sum = 0;
int even = 0;
int odd = 0;

for (int i = min; i <= max; i++) sum += i;

if (min % 2 != 0) min++;
for (int i = min; i <= max; i += 2) even += i;

if (--min % 2 == 0) min++;
for (int i = min; i <= max; i += 2) odd += i;

Console.WriteLine($"Summary: {sum}, Even: {even}, Odd: {odd}");

Console.ReadLine();