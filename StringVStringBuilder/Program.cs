using System.Diagnostics;
using System.Text;

const int max = 100000;

TimeSpan tsS = GetTimeSpanOfString(); // 45s
TimeSpan tsB = GetTimeSpanOfStringBuilder(); //03s
Console.WriteLine($"String:        {tsS}");
Console.WriteLine($"StringBuilder: {tsB}");

static TimeSpan GetTimeSpanOfString()
{
    Stopwatch stopwatchS = new();
    string s = "s";
    stopwatchS.Start();
    for (int i = 0; i < max; i++) s += i;
    Console.WriteLine(s);
    stopwatchS.Stop();
    return stopwatchS.Elapsed;
}

static TimeSpan GetTimeSpanOfStringBuilder()
{
    Stopwatch stopwatchB = new();
    StringBuilder b = new("b");
    stopwatchB.Start();
    for (int i = 0; i < max; i++) b.Append(i);
    Console.WriteLine(b);
    stopwatchB.Stop();
    return stopwatchB.Elapsed;
}