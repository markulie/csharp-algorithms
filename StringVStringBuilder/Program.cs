using System.Diagnostics;
using System.Text;

const int max = 100000;
GetTimeSpanOfString(); // 83s
GetTimeSpanOfStringBuilder(); //00s

static void GetTimeSpanOfString()
{
    Console.WriteLine($"String: appending {max} times");

    Stopwatch stopwatch = new();
    string text = "s";
    stopwatch.Start();
    for (int i = 0; i < max; i++) text += i;
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}
static void GetTimeSpanOfStringBuilder()
{
    Console.WriteLine($"StringBuilder: appending {max} times");

    Stopwatch stopwatch = new();
    StringBuilder text = new("b");
    stopwatch.Start();
    for (int i = 0; i < max; i++) text.Append(i);
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}