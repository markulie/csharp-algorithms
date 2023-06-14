using System.Diagnostics;
using System.Text;

string s = "s";
StringBuilder b = new("b");
const int max = 100;

//- - - - - - - - - - - - - -

Stopwatch stopwatchS = new();
stopwatchS.Start();
for (int i = 0; i < max; i++)
{
    s += i;
    Console.WriteLine(s);
}
stopwatchS.Stop();
TimeSpan elapsedTimeS = stopwatchS.Elapsed;

//- - - - - - - - - - - - - -

Stopwatch stopwatchB = new();
stopwatchB.Start();
for (int i = 0; i < max; i++)
{
    b.Append(i);
    Console.WriteLine(b);
}
stopwatchB.Stop();
TimeSpan elapsedTimeB = stopwatchB.Elapsed;

//- - - - - - - - - - - - - -

Console.WriteLine($"String: {elapsedTimeS}");
Console.WriteLine($"StringBuilder: {elapsedTimeB}");